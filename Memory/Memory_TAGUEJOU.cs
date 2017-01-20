using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dllLoto;
using System.Threading;
using System.Diagnostics;

namespace Memory
{
    public partial class Form1 : Form
    {
        // Déclaration des variables globales du jeu
        int nbCartesDansSabot;            // Nombre de cartes dans le sabot (en fait nombre d'images dans le réservoir)
        int nbCartesSurTapis;             // Nombre de cartes sur le tapis

        Boolean[] carteRetourner;         //Permet de connaitre l'état de chaque carte: Retournée (True), Pas retournée (False)
        int nb_essai;                     //nombre d'essai du joueur
        int id_image;
        Boolean jouer = false;            // Permet de savoir si le joueur est en cours de partie
        int[] tImagesCartes;              // indices des cartes posées sur le tapis
        int[] numCarte = new int[50];     // Contient les numéros des cartes sur lesquels le joueur a cliqué
        int[] numBox = new int[50];       // Contient les numéros des PictureBox sur lesquels le joueur a cliqué
        int erreur;
        int tempsMemorisation ;
        int tempsDeJeu ;
        Boolean lancerChrono;
        

        public Form1()
        {
            InitializeComponent();
        }         

        private void btn_Distribuer_Click(object sender, EventArgs e)   //Dans mon programme, le bouton distribuer n'a pas de réelle  
        {                                                               //Importance, car quand le joueur clique sur JOUER, une nouvelle distribution est éffectué,
                                                                        //Et le chrono pour mémoriser les cartes se déclenche
            if (!jouer) //Si la partie est en cours, le joueur ne peut pas redistribuer les cartes
            {
                // On récupère le nombre d'images dans le réservoir :
                nbCartesDansSabot = ilSabotDeCartes.Images.Count - 1;

                // On récupère également le nombre de cartes à distribuées sur la tapis
                // autrement dit le nombre de contrôles présents sur le conteneur
                nbCartesSurTapis = tlpTapisDeCartes.Controls.Count;

                // On effectue la distribution (aléatoire) proprement dite
                Distribution_Aleatoire();

                carteRetourner = new bool[nbCartesSurTapis]; 
                for (int i = 0; i < nbCartesSurTapis; i++) 
                    carteRetourner[i] = true;
            }
            else
                MessageBox.Show("Veuillez finir votre partie avant de cliquer sur \"DISTRIBUER \" .");
        }

        private void Distribution_Sequentielle()
        {
            PictureBox carte; //carte est un controle qui va à afficher les images
            int i_carte = 1;

            foreach (Control ctrl in tlpTapisDeCartes.Controls)
            {
                carte = (PictureBox)ctrl; //On caste l'objet "ctrl" en PictureBox
                // Ensuite je peux accéder à la propriété Image
                // (je ne pourrais pas si je n'avais pas "casté" le contrôle)
                carte.Image = ilSabotDeCartes.Images[i_carte];
                i_carte++;
            }
        }

        private void Distribution_Aleatoire()
        {
            LotoMachine hasard = new LotoMachine(nbCartesDansSabot);

            List<int> listeCartes = new List<int>();
            int[] tMoitieCartes;
            tMoitieCartes = hasard.TirageAleatoire(nbCartesSurTapis/2, false); //Premier tirage de 4 cartes 

            //On copie 2 fois de suite le tableau dans la liste des cartes
            //On le fait 2 fois pour avoir 4 pairs
            for (int i = 0; i < (nbCartesSurTapis / 2); i++) 
                 listeCartes.Add(tMoitieCartes[i + 1]);
            for (int i = 0; i < (nbCartesSurTapis / 2); i++)
                 listeCartes.Add(tMoitieCartes[i + 1]);

           tImagesCartes = new int[nbCartesSurTapis];

           for(int i = 0; i <nbCartesSurTapis; i++)                      //On copie les cartes dans tImageCarte
              {
                Random rand = new Random();
                int indice;
                do
                {
                    indice = rand.Next(0, nbCartesSurTapis);            //On choisi aléatoirement l'indice d'une carte dans listeCartes
                }   while (listeCartes[indice] == nbCartesDansSabot+1);   
                tImagesCartes[i] = listeCartes[indice];                 //Cette carte sera ajoutée dans tImageCartes
                listeCartes[indice] = nbCartesDansSabot+1;                //On remplace la carte choisie par un numéro qui n'existe pas dans la liste d'image                                                               
            }                                                           //Ainsi, on refait le tirage au sort jusqu'à ce qu'on obtienne une carte dont le numéro
                                                                        //est différent de nbCartesDansSabot, c'est à dire, une carte qui n'a pas encore été tiré  
                                                                        //On repete l'opération tant qu'il reste des cartes
    
            // Affectation des images aux picturebox
            PictureBox carte;
            int i_image;

            for (int i_carte = 0; i_carte < nbCartesSurTapis; i_carte++)
            {
                carte = (PictureBox)tlpTapisDeCartes.Controls[i_carte];     //Le tapis devient une picturebox
                i_image = tImagesCartes[i_carte] + 1;                       // i_carte + 1 à cause des problèmes d'indices
                carte.Image = ilSabotDeCartes.Images[i_image - 1];          
            }
         }
        
        private void btn_Jouer_Click(object sender, EventArgs e)
        {
            if (!jouer)
            {
                erreur = 0;
                MessageBox.Show("Bienvenue dans The Memory\nVous avez droit à 3 erreurs. Vous avez 5 secondes pour mémoriser les cartes, et 30 secondes pour toutes les retourner.");
                btn_Distribuer_Click(sender, e);
                jouer = true;
                tempsMemorisation = 0;
                timer1.Start();                  // Timer pour tourner les cartes
                timerTempsJeu.Start();           // Temps de jeu
                nb_essai = 0;
            }
            else
                MessageBox.Show("Veuillez finir votre partie avant de cliquer sur \"JOUER \" .");
        }

        private int carte_choisie(object sender)                                 //Cette fonction va permettre de trouver l'indice 
        {                                                                        //de la carte sur laquelle le joueur a cliqué
            id_image = 0;
            if (sender is PictureBox)                                            //Si on clique sur une pictureBox
                {
                string pbNom = ((PictureBox)sender).Name;                        //On garde son nom en mémoire               
                    while (tlpTapisDeCartes.Controls[id_image].Name != pbNom)
                    {
                        id_image++;                                              //On parcourt les picturebox jusqu'à ce qu'on      
                    }                                                            //trouve celle sur laquelle le joueur a cliqué 
            }
            return id_image;
        }

        private void retournerCarte(int i)                                      //Elle va permettre d'afficher le dos des cartes
        {
            PictureBox carte;
            carte = (PictureBox)tlpTapisDeCartes.Controls[i - 1];
            if (!carteRetourner[i - 1])                                          //si la carte n'est pas retournée
            {
                carte.Image = ilSabotDeCartes.Images[tImagesCartes[i - 1]];      //Affiche le dos  de l'image
                carteRetourner[i - 1] = true;
            }
            else
            {
                carte.Image = ilSabotDeCartes.Images[0];                         //sinon, on reste sur le dos de la carte
                carteRetourner[i - 1] = false;
            }
        }

        private void retournerCarteTapis() //Permet de retourner les cartes en fin de jeu
        {
            for (int i = 1; i < nbCartesSurTapis + 1; i++)
            {
                retournerCarte(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempsMemorisation++;  
            if (tempsMemorisation == 5)                              //J'ai modifié l'interval du timer à 1000 Millisecondes
            {
                lancerChrono = true;
                retournerCarteTapis();
                MessageBox.Show("Temps écoulé.");
            }
           
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (jouer)                                              //Si le joueur clique sur "JOUER"
            {
                carte_choisie(sender);                              //On cherche l'id de la carte

                    if (!carteRetourner[id_image])                  //La boucle est exécutée seulement si la carte n'est pas encore retournée
                    {
                        retournerCarte(id_image + 1);

                    if(erreur < 3)                                   
                    {
                        numBox[nb_essai] = id_image;                 //On stocke le numéro de la PictureBox
                        numCarte[nb_essai] = tImagesCartes[id_image];//On stocke l'id de la carte

                        if (nb_essai >= 1 && nb_essai % 2 == 1)      //Si le joueur a retourné 2 carte, on vérifie s'ils sont similaires
                        {
                            retournerPair(nb_essai, nb_essai - 1);
                            resultat();
                        }
                    }
                        nb_essai++;
                    }
                    else //Si la carte est dejà retournée...
                    {
                        MessageBox.Show("Cette carte est déjà retournée");
                    }
                }
          }

        protected void btn_Retourner_Click(object sender, EventArgs e)
        {
                retournerCarteTapis();      //Quand on clique sur le bouton retourné, les cartes qui ont déjà été retournée sont de dos
        }                                   //C'est un choix de ma part pour permettre à l'utilisateur de résoudre sa partie 
                                            //sans s'encombrer des cartes qu'il a déjà trouvée
        public void resultat()
        {
            int nbrCarteRetourne = 0;
            for (int i = 0; i < nbCartesSurTapis; i++){
                if (carteRetourner[i])
                    nbrCarteRetourne++;
            }
            
            if(nbrCarteRetourne == 8)   //Si toutes les 8 cartes sont retournée...
            {
                MessageBox.Show("Félicitation !!! Vous êtes parvenu à trouver toutes les paires. Vous avez fait "+erreur+ " erreur(s). Si vous souhaitez continuer à jouer, cliquez sur \"JOUER\" .");
                jouer = false;
            }
        }

        public void retournerPair(int i, int j)
        {
            if (numCarte[i] + 1 != numCarte[j] + 1 )
            {
                MessageBox.Show("FAUX !!!");
                retournerCarte(numBox[i] + 1); //On affiche le dos des cartes
                retournerCarte(numBox[j] + 1);

                erreur++;
                if (erreur > 2)                 //Le joueur a droit à 3 erreurs
                {
                    jouer = false;
                    MessageBox.Show("Vous avez perdu !");

                    //Retourner les cartes
                    for (int k = 1; k < nbCartesSurTapis + 1; k++)
                    {
                        PictureBox carte = (PictureBox)tlpTapisDeCartes.Controls[k - 1];
                        carte.Image = ilSabotDeCartes.Images[tImagesCartes[k - 1]]; //Affiche le verso de l'image
                    }
                }
            }
            else
            {
                MessageBox.Show("Bravo");
            }
}

        private void timerTempsJeu_Tick(object sender, EventArgs e)
        {
            if (lancerChrono)
            {
                tempsDeJeu++;
                label3.Text = Convert.ToString(tempsDeJeu)+" Secondes";
                if (tempsDeJeu == 30)
                {
                    jouer = false;
                    timerTempsJeu.Stop();
                    MessageBox.Show("Partie terminée. Vous avez perdu.");

                    //Retourner les cartes
                    for (int k = 1; k < nbCartesSurTapis + 1; k++)
                    {
                        PictureBox carte = (PictureBox)tlpTapisDeCartes.Controls[k - 1];
                        carte.Image = ilSabotDeCartes.Images[tImagesCartes[k - 1]]; //Affiche le verso de l'image
                    }
                }
                else if(tempsDeJeu < 30 && jouer == false)
                {
                    timerTempsJeu.Stop();
                    tempsDeJeu = 0;
                    lancerChrono = false;
                }
            }
        }
    }
   }

    

