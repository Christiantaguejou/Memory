namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpTapisDeCartes = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_04 = new System.Windows.Forms.PictureBox();
            this.pb_03 = new System.Windows.Forms.PictureBox();
            this.pb_02 = new System.Windows.Forms.PictureBox();
            this.pb_01 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Distribuer = new System.Windows.Forms.Button();
            this.ilSabotDeCartes = new System.Windows.Forms.ImageList(this.components);
            this.btn_Jouer = new System.Windows.Forms.Button();
            this.btn_Retourner = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerTempsJeu = new System.Windows.Forms.Timer(this.components);
            this.tlpTapisDeCartes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTapisDeCartes
            // 
            this.tlpTapisDeCartes.ColumnCount = 4;
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTapisDeCartes.Controls.Add(this.pictureBox5, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pictureBox3, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pictureBox2, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pictureBox1, 0, 1);
            this.tlpTapisDeCartes.Controls.Add(this.pb_04, 3, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_03, 2, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_02, 1, 0);
            this.tlpTapisDeCartes.Controls.Add(this.pb_01, 0, 0);
            this.tlpTapisDeCartes.Location = new System.Drawing.Point(0, 0);
            this.tlpTapisDeCartes.Name = "tlpTapisDeCartes";
            this.tlpTapisDeCartes.RowCount = 2;
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTapisDeCartes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpTapisDeCartes.Size = new System.Drawing.Size(440, 222);
            this.tlpTapisDeCartes.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 110);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(113, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(223, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(333, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb_04
            // 
            this.pb_04.Location = new System.Drawing.Point(333, 3);
            this.pb_04.Name = "pb_04";
            this.pb_04.Size = new System.Drawing.Size(100, 100);
            this.pb_04.TabIndex = 10;
            this.pb_04.TabStop = false;
            this.pb_04.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb_03
            // 
            this.pb_03.Location = new System.Drawing.Point(223, 3);
            this.pb_03.Name = "pb_03";
            this.pb_03.Size = new System.Drawing.Size(100, 100);
            this.pb_03.TabIndex = 9;
            this.pb_03.TabStop = false;
            this.pb_03.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb_02
            // 
            this.pb_02.Location = new System.Drawing.Point(113, 3);
            this.pb_02.Name = "pb_02";
            this.pb_02.Size = new System.Drawing.Size(100, 100);
            this.pb_02.TabIndex = 8;
            this.pb_02.TabStop = false;
            this.pb_02.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb_01
            // 
            this.pb_01.Location = new System.Drawing.Point(3, 3);
            this.pb_01.Name = "pb_01";
            this.pb_01.Size = new System.Drawing.Size(100, 100);
            this.pb_01.TabIndex = 7;
            this.pb_01.TabStop = false;
            this.pb_01.Click += new System.EventHandler(this.pb_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(340, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Distribuer
            // 
            this.btn_Distribuer.Location = new System.Drawing.Point(48, 228);
            this.btn_Distribuer.Name = "btn_Distribuer";
            this.btn_Distribuer.Size = new System.Drawing.Size(86, 23);
            this.btn_Distribuer.TabIndex = 1;
            this.btn_Distribuer.Text = "DISTRIBUER";
            this.btn_Distribuer.UseVisualStyleBackColor = true;
            this.btn_Distribuer.Click += new System.EventHandler(this.btn_Distribuer_Click);
            // 
            // ilSabotDeCartes
            // 
            this.ilSabotDeCartes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSabotDeCartes.ImageStream")));
            this.ilSabotDeCartes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSabotDeCartes.Images.SetKeyName(0, "DosCarte.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(1, "Dialogue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(2, "Diplome.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(3, "FemmeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(4, "FemmeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(5, "FemmeBlanche.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(6, "FemmeBleue.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(7, "FemmeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(8, "FemmeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(9, "FemmeInformaticienBrune.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(10, "FemmeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(11, "FemmeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(12, "FemmeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(13, "FemmeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(14, "FemmeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(15, "FemmePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(16, "FemmePoliciere.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(17, "HommeAffaire.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(18, "HommeBatiment.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(19, "HommeBleu.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(20, "HommeCasque.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(21, "HommeCuisinier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(22, "HommeGarde.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(23, "HommeInformaticienBrun.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(24, "HommeInformaticienChatain.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(25, "HommeJournal.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(26, "HommeMarron.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(27, "HommeMedecin.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(28, "HommeMegaphone.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(29, "HommeOrange.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(30, "HommePhotographe.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(31, "HommePolicier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(32, "Joker.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(33, "LivreurPizza.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(34, "MarinMousse.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(35, "MarinOfficier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(36, "MarinPompon.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(37, "Mecanicien.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(38, "Pilote.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(39, "Pompier.jpg");
            this.ilSabotDeCartes.Images.SetKeyName(40, "Serveur.jpg");
            // 
            // btn_Jouer
            // 
            this.btn_Jouer.Location = new System.Drawing.Point(156, 228);
            this.btn_Jouer.Name = "btn_Jouer";
            this.btn_Jouer.Size = new System.Drawing.Size(75, 23);
            this.btn_Jouer.TabIndex = 4;
            this.btn_Jouer.Text = "JOUER";
            this.btn_Jouer.UseVisualStyleBackColor = true;
            this.btn_Jouer.Click += new System.EventHandler(this.btn_Jouer_Click);
            // 
            // btn_Retourner
            // 
            this.btn_Retourner.Location = new System.Drawing.Point(250, 228);
            this.btn_Retourner.Name = "btn_Retourner";
            this.btn_Retourner.Size = new System.Drawing.Size(104, 23);
            this.btn_Retourner.TabIndex = 7;
            this.btn_Retourner.Text = "RETOURNER";
            this.btn_Retourner.UseVisualStyleBackColor = true;
            this.btn_Retourner.Click += new System.EventHandler(this.btn_Retourner_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "The Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chrono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // timerTempsJeu
            // 
            this.timerTempsJeu.Interval = 1000;
            this.timerTempsJeu.Tick += new System.EventHandler(this.timerTempsJeu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Retourner);
            this.Controls.Add(this.btn_Jouer);
            this.Controls.Add(this.btn_Distribuer);
            this.Controls.Add(this.tlpTapisDeCartes);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.timer1_Tick);
            this.tlpTapisDeCartes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTapisDeCartes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Distribuer;
        private System.Windows.Forms.ImageList ilSabotDeCartes;
        private System.Windows.Forms.Button btn_Jouer;
        private System.Windows.Forms.PictureBox pb_04;
        private System.Windows.Forms.PictureBox pb_03;
        private System.Windows.Forms.PictureBox pb_02;
        private System.Windows.Forms.PictureBox pb_01;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Retourner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerTempsJeu;
    }
}

