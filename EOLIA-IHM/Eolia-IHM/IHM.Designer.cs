﻿namespace Eolia_IHM
{
    partial class IHM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EOLIATitre = new System.Windows.Forms.Label();
            this.ConteneurOngletBouton = new System.Windows.Forms.Panel();
            this.BoutonQuitter = new System.Windows.Forms.Button();
            this.BoutonOngletConfig = new System.Windows.Forms.Button();
            this.BoutonOngletMesure = new System.Windows.Forms.Button();
            this.BoutonOngletEtat = new System.Windows.Forms.Button();
            this.GroupBoxEtat = new System.Windows.Forms.GroupBox();
            this.GroupBoxMesure = new System.Windows.Forms.GroupBox();
            this.GroupBoxConfig = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.textBoxCZ = new System.Windows.Forms.TextBox();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.textBoxNomBDDMYSQL = new System.Windows.Forms.TextBox();
            this.textBoxMotdepasseMYSQL = new System.Windows.Forms.TextBox();
            this.textBoxUsernameMYSQL = new System.Windows.Forms.TextBox();
            this.textBoxAdresseMYSQL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboxBoxChoixPortSerie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxNumpad = new System.Windows.Forms.GroupBox();
            this.BoutonNumpadDel = new System.Windows.Forms.Button();
            this.BoutonNumpad0 = new System.Windows.Forms.Button();
            this.BoutonNumpadDot = new System.Windows.Forms.Button();
            this.BoutonNumpad9 = new System.Windows.Forms.Button();
            this.BoutonNumpad8 = new System.Windows.Forms.Button();
            this.BoutonNumpad7 = new System.Windows.Forms.Button();
            this.BoutonNumpad6 = new System.Windows.Forms.Button();
            this.BoutonNumpad5 = new System.Windows.Forms.Button();
            this.BoutonNumpad4 = new System.Windows.Forms.Button();
            this.BoutonNumpad3 = new System.Windows.Forms.Button();
            this.BoutonNumpad2 = new System.Windows.Forms.Button();
            this.BoutonNumpad1 = new System.Windows.Forms.Button();
            this.BoutonRecharger = new System.Windows.Forms.Button();
            this.BoutonSauvegarde = new System.Windows.Forms.Button();
            this.BoutonRechargerPortSerie = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEtatLiaisonSerie = new System.Windows.Forms.TextBox();
            this.buttonDemarrerLiaisonSerie = new System.Windows.Forms.Button();
            this.buttonArreterLiaisonSerie = new System.Windows.Forms.Button();
            this.ConteneurOngletBouton.SuspendLayout();
            this.GroupBoxEtat.SuspendLayout();
            this.GroupBoxConfig.SuspendLayout();
            this.GroupBoxNumpad.SuspendLayout();
            this.SuspendLayout();
            // 
            // EOLIATitre
            // 
            this.EOLIATitre.AutoSize = true;
            this.EOLIATitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.6F);
            this.EOLIATitre.Location = new System.Drawing.Point(436, 9);
            this.EOLIATitre.Name = "EOLIATitre";
            this.EOLIATitre.Size = new System.Drawing.Size(118, 39);
            this.EOLIATitre.TabIndex = 2;
            this.EOLIATitre.Text = "EOLIA";
            // 
            // ConteneurOngletBouton
            // 
            this.ConteneurOngletBouton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ConteneurOngletBouton.Controls.Add(this.BoutonQuitter);
            this.ConteneurOngletBouton.Controls.Add(this.BoutonOngletConfig);
            this.ConteneurOngletBouton.Controls.Add(this.BoutonOngletMesure);
            this.ConteneurOngletBouton.Controls.Add(this.BoutonOngletEtat);
            this.ConteneurOngletBouton.Location = new System.Drawing.Point(12, 63);
            this.ConteneurOngletBouton.Name = "ConteneurOngletBouton";
            this.ConteneurOngletBouton.Size = new System.Drawing.Size(1000, 59);
            this.ConteneurOngletBouton.TabIndex = 3;
            // 
            // BoutonQuitter
            // 
            this.BoutonQuitter.Location = new System.Drawing.Point(872, 3);
            this.BoutonQuitter.Name = "BoutonQuitter";
            this.BoutonQuitter.Size = new System.Drawing.Size(125, 53);
            this.BoutonQuitter.TabIndex = 3;
            this.BoutonQuitter.Text = "Quitter";
            this.BoutonQuitter.UseVisualStyleBackColor = true;
            this.BoutonQuitter.Click += new System.EventHandler(this.BoutonQuitter_Click);
            // 
            // BoutonOngletConfig
            // 
            this.BoutonOngletConfig.Location = new System.Drawing.Point(335, 3);
            this.BoutonOngletConfig.Name = "BoutonOngletConfig";
            this.BoutonOngletConfig.Size = new System.Drawing.Size(164, 53);
            this.BoutonOngletConfig.TabIndex = 2;
            this.BoutonOngletConfig.Text = "Configuration";
            this.BoutonOngletConfig.UseVisualStyleBackColor = true;
            this.BoutonOngletConfig.Click += new System.EventHandler(this.BoutonOngletConfig_Click);
            // 
            // BoutonOngletMesure
            // 
            this.BoutonOngletMesure.Location = new System.Drawing.Point(169, 3);
            this.BoutonOngletMesure.Name = "BoutonOngletMesure";
            this.BoutonOngletMesure.Size = new System.Drawing.Size(164, 53);
            this.BoutonOngletMesure.TabIndex = 1;
            this.BoutonOngletMesure.Text = "Mesure";
            this.BoutonOngletMesure.UseVisualStyleBackColor = true;
            this.BoutonOngletMesure.Click += new System.EventHandler(this.BoutonOngletMesure_Click);
            // 
            // BoutonOngletEtat
            // 
            this.BoutonOngletEtat.Location = new System.Drawing.Point(3, 3);
            this.BoutonOngletEtat.Name = "BoutonOngletEtat";
            this.BoutonOngletEtat.Size = new System.Drawing.Size(164, 53);
            this.BoutonOngletEtat.TabIndex = 0;
            this.BoutonOngletEtat.Text = "Etat";
            this.BoutonOngletEtat.UseVisualStyleBackColor = true;
            this.BoutonOngletEtat.Click += new System.EventHandler(this.BoutonOngletEtat_Click);
            // 
            // GroupBoxEtat
            // 
            this.GroupBoxEtat.BackColor = System.Drawing.Color.White;
            this.GroupBoxEtat.Controls.Add(this.buttonArreterLiaisonSerie);
            this.GroupBoxEtat.Controls.Add(this.buttonDemarrerLiaisonSerie);
            this.GroupBoxEtat.Controls.Add(this.textBoxEtatLiaisonSerie);
            this.GroupBoxEtat.Controls.Add(this.label12);
            this.GroupBoxEtat.Location = new System.Drawing.Point(12, 128);
            this.GroupBoxEtat.Name = "GroupBoxEtat";
            this.GroupBoxEtat.Size = new System.Drawing.Size(1000, 460);
            this.GroupBoxEtat.TabIndex = 4;
            this.GroupBoxEtat.TabStop = false;
            this.GroupBoxEtat.Text = "GroupBoxEtat";
            this.GroupBoxEtat.Visible = false;
            // 
            // GroupBoxMesure
            // 
            this.GroupBoxMesure.BackColor = System.Drawing.Color.White;
            this.GroupBoxMesure.Location = new System.Drawing.Point(12, 128);
            this.GroupBoxMesure.Name = "GroupBoxMesure";
            this.GroupBoxMesure.Size = new System.Drawing.Size(1000, 460);
            this.GroupBoxMesure.TabIndex = 5;
            this.GroupBoxMesure.TabStop = false;
            this.GroupBoxMesure.Text = "GroupBoxMesure";
            this.GroupBoxMesure.Visible = false;
            // 
            // GroupBoxConfig
            // 
            this.GroupBoxConfig.BackColor = System.Drawing.Color.White;
            this.GroupBoxConfig.Controls.Add(this.BoutonRechargerPortSerie);
            this.GroupBoxConfig.Controls.Add(this.label11);
            this.GroupBoxConfig.Controls.Add(this.textBoxS);
            this.GroupBoxConfig.Controls.Add(this.textBoxV);
            this.GroupBoxConfig.Controls.Add(this.textBoxp);
            this.GroupBoxConfig.Controls.Add(this.textBoxCZ);
            this.GroupBoxConfig.Controls.Add(this.textBoxCX);
            this.GroupBoxConfig.Controls.Add(this.textBoxNomBDDMYSQL);
            this.GroupBoxConfig.Controls.Add(this.textBoxMotdepasseMYSQL);
            this.GroupBoxConfig.Controls.Add(this.textBoxUsernameMYSQL);
            this.GroupBoxConfig.Controls.Add(this.textBoxAdresseMYSQL);
            this.GroupBoxConfig.Controls.Add(this.label10);
            this.GroupBoxConfig.Controls.Add(this.label9);
            this.GroupBoxConfig.Controls.Add(this.label8);
            this.GroupBoxConfig.Controls.Add(this.label7);
            this.GroupBoxConfig.Controls.Add(this.label6);
            this.GroupBoxConfig.Controls.Add(this.ComboxBoxChoixPortSerie);
            this.GroupBoxConfig.Controls.Add(this.label5);
            this.GroupBoxConfig.Controls.Add(this.label4);
            this.GroupBoxConfig.Controls.Add(this.label3);
            this.GroupBoxConfig.Controls.Add(this.label2);
            this.GroupBoxConfig.Controls.Add(this.label1);
            this.GroupBoxConfig.Controls.Add(this.GroupBoxNumpad);
            this.GroupBoxConfig.Controls.Add(this.BoutonRecharger);
            this.GroupBoxConfig.Controls.Add(this.BoutonSauvegarde);
            this.GroupBoxConfig.Location = new System.Drawing.Point(12, 128);
            this.GroupBoxConfig.Name = "GroupBoxConfig";
            this.GroupBoxConfig.Size = new System.Drawing.Size(1000, 460);
            this.GroupBoxConfig.TabIndex = 6;
            this.GroupBoxConfig.TabStop = false;
            this.GroupBoxConfig.Text = "GroupBoxConfig";
            this.GroupBoxConfig.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Les réglages de la BDD sont configurables uniquement via le fichier .config";
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(59, 280);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(71, 20);
            this.textBoxS.TabIndex = 22;
            this.textBoxS.Click += new System.EventHandler(this.textBoxS_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(59, 254);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(71, 20);
            this.textBoxV.TabIndex = 21;
            this.textBoxV.Click += new System.EventHandler(this.textBoxV_Click);
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(59, 228);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.Size = new System.Drawing.Size(71, 20);
            this.textBoxp.TabIndex = 20;
            this.textBoxp.Click += new System.EventHandler(this.textBoxp_Click);
            // 
            // textBoxCZ
            // 
            this.textBoxCZ.Location = new System.Drawing.Point(59, 202);
            this.textBoxCZ.Name = "textBoxCZ";
            this.textBoxCZ.Size = new System.Drawing.Size(71, 20);
            this.textBoxCZ.TabIndex = 19;
            this.textBoxCZ.Click += new System.EventHandler(this.textBoxCZ_Click);
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(59, 178);
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(71, 20);
            this.textBoxCX.TabIndex = 18;
            this.textBoxCX.Click += new System.EventHandler(this.textBoxCX_Click);
            // 
            // textBoxNomBDDMYSQL
            // 
            this.textBoxNomBDDMYSQL.Location = new System.Drawing.Point(206, 108);
            this.textBoxNomBDDMYSQL.Name = "textBoxNomBDDMYSQL";
            this.textBoxNomBDDMYSQL.ReadOnly = true;
            this.textBoxNomBDDMYSQL.Size = new System.Drawing.Size(186, 20);
            this.textBoxNomBDDMYSQL.TabIndex = 17;
            // 
            // textBoxMotdepasseMYSQL
            // 
            this.textBoxMotdepasseMYSQL.Location = new System.Drawing.Point(248, 89);
            this.textBoxMotdepasseMYSQL.Name = "textBoxMotdepasseMYSQL";
            this.textBoxMotdepasseMYSQL.ReadOnly = true;
            this.textBoxMotdepasseMYSQL.Size = new System.Drawing.Size(186, 20);
            this.textBoxMotdepasseMYSQL.TabIndex = 16;
            // 
            // textBoxUsernameMYSQL
            // 
            this.textBoxUsernameMYSQL.Location = new System.Drawing.Point(267, 70);
            this.textBoxUsernameMYSQL.Name = "textBoxUsernameMYSQL";
            this.textBoxUsernameMYSQL.ReadOnly = true;
            this.textBoxUsernameMYSQL.Size = new System.Drawing.Size(186, 20);
            this.textBoxUsernameMYSQL.TabIndex = 15;
            // 
            // textBoxAdresseMYSQL
            // 
            this.textBoxAdresseMYSQL.Location = new System.Drawing.Point(175, 51);
            this.textBoxAdresseMYSQL.Name = "textBoxAdresseMYSQL";
            this.textBoxAdresseMYSQL.ReadOnly = true;
            this.textBoxAdresseMYSQL.Size = new System.Drawing.Size(186, 20);
            this.textBoxAdresseMYSQL.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "p";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cx";
            // 
            // ComboxBoxChoixPortSerie
            // 
            this.ComboxBoxChoixPortSerie.FormattingEnabled = true;
            this.ComboxBoxChoixPortSerie.Location = new System.Drawing.Point(140, 146);
            this.ComboxBoxChoixPortSerie.Name = "ComboxBoxChoixPortSerie";
            this.ComboxBoxChoixPortSerie.Size = new System.Drawing.Size(160, 21);
            this.ComboxBoxChoixPortSerie.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choix du port série :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mot de passe de la base de donée MYSQL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom d\'utilisateur de la base de donnée MYSQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de la base de donée MYSQL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresse du serveur MYSQL";
            // 
            // GroupBoxNumpad
            // 
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpadDel);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad0);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpadDot);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad9);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad8);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad7);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad6);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad5);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad4);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad3);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad2);
            this.GroupBoxNumpad.Controls.Add(this.BoutonNumpad1);
            this.GroupBoxNumpad.Location = new System.Drawing.Point(780, 162);
            this.GroupBoxNumpad.Name = "GroupBoxNumpad";
            this.GroupBoxNumpad.Size = new System.Drawing.Size(214, 292);
            this.GroupBoxNumpad.TabIndex = 2;
            this.GroupBoxNumpad.TabStop = false;
            this.GroupBoxNumpad.Text = "Pavé numérique";
            // 
            // BoutonNumpadDel
            // 
            this.BoutonNumpadDel.Location = new System.Drawing.Point(146, 217);
            this.BoutonNumpadDel.Name = "BoutonNumpadDel";
            this.BoutonNumpadDel.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpadDel.TabIndex = 11;
            this.BoutonNumpadDel.Text = "Suppr";
            this.BoutonNumpadDel.UseVisualStyleBackColor = true;
            this.BoutonNumpadDel.Click += new System.EventHandler(this.BoutonNumpadDel_Click);
            // 
            // BoutonNumpad0
            // 
            this.BoutonNumpad0.Location = new System.Drawing.Point(76, 217);
            this.BoutonNumpad0.Name = "BoutonNumpad0";
            this.BoutonNumpad0.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad0.TabIndex = 10;
            this.BoutonNumpad0.Text = "0";
            this.BoutonNumpad0.UseVisualStyleBackColor = true;
            this.BoutonNumpad0.Click += new System.EventHandler(this.BoutonNumpad0_Click);
            // 
            // BoutonNumpadDot
            // 
            this.BoutonNumpadDot.Location = new System.Drawing.Point(6, 217);
            this.BoutonNumpadDot.Name = "BoutonNumpadDot";
            this.BoutonNumpadDot.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpadDot.TabIndex = 9;
            this.BoutonNumpadDot.Text = ".";
            this.BoutonNumpadDot.UseVisualStyleBackColor = true;
            this.BoutonNumpadDot.Click += new System.EventHandler(this.BoutonNumpadDot_Click);
            // 
            // BoutonNumpad9
            // 
            this.BoutonNumpad9.Location = new System.Drawing.Point(146, 151);
            this.BoutonNumpad9.Name = "BoutonNumpad9";
            this.BoutonNumpad9.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad9.TabIndex = 8;
            this.BoutonNumpad9.Text = "9";
            this.BoutonNumpad9.UseVisualStyleBackColor = true;
            this.BoutonNumpad9.Click += new System.EventHandler(this.BoutonNumpad9_Click);
            // 
            // BoutonNumpad8
            // 
            this.BoutonNumpad8.Location = new System.Drawing.Point(76, 151);
            this.BoutonNumpad8.Name = "BoutonNumpad8";
            this.BoutonNumpad8.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad8.TabIndex = 7;
            this.BoutonNumpad8.Text = "8";
            this.BoutonNumpad8.UseVisualStyleBackColor = true;
            this.BoutonNumpad8.Click += new System.EventHandler(this.BoutonNumpad8_Click);
            // 
            // BoutonNumpad7
            // 
            this.BoutonNumpad7.Location = new System.Drawing.Point(6, 151);
            this.BoutonNumpad7.Name = "BoutonNumpad7";
            this.BoutonNumpad7.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad7.TabIndex = 6;
            this.BoutonNumpad7.Text = "7";
            this.BoutonNumpad7.UseVisualStyleBackColor = true;
            this.BoutonNumpad7.Click += new System.EventHandler(this.BoutonNumpad7_Click);
            // 
            // BoutonNumpad6
            // 
            this.BoutonNumpad6.Location = new System.Drawing.Point(146, 85);
            this.BoutonNumpad6.Name = "BoutonNumpad6";
            this.BoutonNumpad6.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad6.TabIndex = 5;
            this.BoutonNumpad6.Text = "6";
            this.BoutonNumpad6.UseVisualStyleBackColor = true;
            this.BoutonNumpad6.Click += new System.EventHandler(this.BoutonNumpad6_Click);
            // 
            // BoutonNumpad5
            // 
            this.BoutonNumpad5.Location = new System.Drawing.Point(76, 85);
            this.BoutonNumpad5.Name = "BoutonNumpad5";
            this.BoutonNumpad5.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad5.TabIndex = 4;
            this.BoutonNumpad5.Text = "5";
            this.BoutonNumpad5.UseVisualStyleBackColor = true;
            this.BoutonNumpad5.Click += new System.EventHandler(this.BoutonNumpad5_Click);
            // 
            // BoutonNumpad4
            // 
            this.BoutonNumpad4.Location = new System.Drawing.Point(6, 85);
            this.BoutonNumpad4.Name = "BoutonNumpad4";
            this.BoutonNumpad4.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad4.TabIndex = 3;
            this.BoutonNumpad4.Text = "4";
            this.BoutonNumpad4.UseVisualStyleBackColor = true;
            this.BoutonNumpad4.Click += new System.EventHandler(this.BoutonNumpad4_Click);
            // 
            // BoutonNumpad3
            // 
            this.BoutonNumpad3.Location = new System.Drawing.Point(144, 19);
            this.BoutonNumpad3.Name = "BoutonNumpad3";
            this.BoutonNumpad3.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad3.TabIndex = 2;
            this.BoutonNumpad3.Text = "3";
            this.BoutonNumpad3.UseVisualStyleBackColor = true;
            this.BoutonNumpad3.Click += new System.EventHandler(this.BoutonNumpad3_Click);
            // 
            // BoutonNumpad2
            // 
            this.BoutonNumpad2.Location = new System.Drawing.Point(76, 19);
            this.BoutonNumpad2.Name = "BoutonNumpad2";
            this.BoutonNumpad2.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad2.TabIndex = 1;
            this.BoutonNumpad2.Text = "2";
            this.BoutonNumpad2.UseVisualStyleBackColor = true;
            this.BoutonNumpad2.Click += new System.EventHandler(this.BoutonNumpad2_Click);
            // 
            // BoutonNumpad1
            // 
            this.BoutonNumpad1.Location = new System.Drawing.Point(6, 19);
            this.BoutonNumpad1.Name = "BoutonNumpad1";
            this.BoutonNumpad1.Size = new System.Drawing.Size(64, 60);
            this.BoutonNumpad1.TabIndex = 0;
            this.BoutonNumpad1.Text = "1";
            this.BoutonNumpad1.UseVisualStyleBackColor = true;
            this.BoutonNumpad1.Click += new System.EventHandler(this.BoutonNumpad1_Click);
            // 
            // BoutonRecharger
            // 
            this.BoutonRecharger.Location = new System.Drawing.Point(791, 19);
            this.BoutonRecharger.Name = "BoutonRecharger";
            this.BoutonRecharger.Size = new System.Drawing.Size(203, 35);
            this.BoutonRecharger.TabIndex = 1;
            this.BoutonRecharger.Text = "Recharger Configuration";
            this.BoutonRecharger.UseVisualStyleBackColor = true;
            // 
            // BoutonSauvegarde
            // 
            this.BoutonSauvegarde.Location = new System.Drawing.Point(791, 60);
            this.BoutonSauvegarde.Name = "BoutonSauvegarde";
            this.BoutonSauvegarde.Size = new System.Drawing.Size(203, 29);
            this.BoutonSauvegarde.TabIndex = 0;
            this.BoutonSauvegarde.Text = "Sauvegarder Configuration";
            this.BoutonSauvegarde.UseVisualStyleBackColor = true;
            this.BoutonSauvegarde.Click += new System.EventHandler(this.BoutonSauvegarde_Click);
            // 
            // BoutonRechargerPortSerie
            // 
            this.BoutonRechargerPortSerie.Location = new System.Drawing.Point(791, 95);
            this.BoutonRechargerPortSerie.Name = "BoutonRechargerPortSerie";
            this.BoutonRechargerPortSerie.Size = new System.Drawing.Size(203, 29);
            this.BoutonRechargerPortSerie.TabIndex = 24;
            this.BoutonRechargerPortSerie.Text = "Recharger port série";
            this.BoutonRechargerPortSerie.UseVisualStyleBackColor = true;
            this.BoutonRechargerPortSerie.Click += new System.EventHandler(this.BoutonRechargerPortSerie_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Etat liaison série :";
            // 
            // textBoxEtatLiaisonSerie
            // 
            this.textBoxEtatLiaisonSerie.Location = new System.Drawing.Point(142, 38);
            this.textBoxEtatLiaisonSerie.Name = "textBoxEtatLiaisonSerie";
            this.textBoxEtatLiaisonSerie.Size = new System.Drawing.Size(158, 20);
            this.textBoxEtatLiaisonSerie.TabIndex = 1;
            this.textBoxEtatLiaisonSerie.Text = "Arreter";
            // 
            // buttonDemarrerLiaisonSerie
            // 
            this.buttonDemarrerLiaisonSerie.Location = new System.Drawing.Point(317, 38);
            this.buttonDemarrerLiaisonSerie.Name = "buttonDemarrerLiaisonSerie";
            this.buttonDemarrerLiaisonSerie.Size = new System.Drawing.Size(97, 23);
            this.buttonDemarrerLiaisonSerie.TabIndex = 2;
            this.buttonDemarrerLiaisonSerie.Text = "Démarrer";
            this.buttonDemarrerLiaisonSerie.UseVisualStyleBackColor = true;
            this.buttonDemarrerLiaisonSerie.Click += new System.EventHandler(this.buttonDemarrerLiaisonSerie_Click);
            // 
            // buttonArreterLiaisonSerie
            // 
            this.buttonArreterLiaisonSerie.Location = new System.Drawing.Point(420, 41);
            this.buttonArreterLiaisonSerie.Name = "buttonArreterLiaisonSerie";
            this.buttonArreterLiaisonSerie.Size = new System.Drawing.Size(97, 23);
            this.buttonArreterLiaisonSerie.TabIndex = 3;
            this.buttonArreterLiaisonSerie.Text = "Arreter";
            this.buttonArreterLiaisonSerie.UseVisualStyleBackColor = true;
            this.buttonArreterLiaisonSerie.Click += new System.EventHandler(this.buttonArreterLiaisonSerie_Click);
            // 
            // IHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.ConteneurOngletBouton);
            this.Controls.Add(this.EOLIATitre);
            this.Controls.Add(this.GroupBoxEtat);
            this.Controls.Add(this.GroupBoxConfig);
            this.Controls.Add(this.GroupBoxMesure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(3024, 1618);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "IHM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IHM";
            this.Load += new System.EventHandler(this.IHM_Load);
            this.ConteneurOngletBouton.ResumeLayout(false);
            this.GroupBoxEtat.ResumeLayout(false);
            this.GroupBoxEtat.PerformLayout();
            this.GroupBoxConfig.ResumeLayout(false);
            this.GroupBoxConfig.PerformLayout();
            this.GroupBoxNumpad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EOLIATitre;
        private System.Windows.Forms.Panel ConteneurOngletBouton;
        private System.Windows.Forms.Button BoutonQuitter;
        private System.Windows.Forms.Button BoutonOngletConfig;
        private System.Windows.Forms.Button BoutonOngletMesure;
        private System.Windows.Forms.Button BoutonOngletEtat;
        private System.Windows.Forms.GroupBox GroupBoxEtat;
        private System.Windows.Forms.GroupBox GroupBoxMesure;
        private System.Windows.Forms.GroupBox GroupBoxConfig;
        private System.Windows.Forms.Button BoutonSauvegarde;
        private System.Windows.Forms.GroupBox GroupBoxNumpad;
        private System.Windows.Forms.Button BoutonRecharger;
        private System.Windows.Forms.Button BoutonNumpad0;
        private System.Windows.Forms.Button BoutonNumpadDot;
        private System.Windows.Forms.Button BoutonNumpad9;
        private System.Windows.Forms.Button BoutonNumpad8;
        private System.Windows.Forms.Button BoutonNumpad7;
        private System.Windows.Forms.Button BoutonNumpad6;
        private System.Windows.Forms.Button BoutonNumpad5;
        private System.Windows.Forms.Button BoutonNumpad4;
        private System.Windows.Forms.Button BoutonNumpad3;
        private System.Windows.Forms.Button BoutonNumpad2;
        private System.Windows.Forms.Button BoutonNumpad1;
        private System.Windows.Forms.Button BoutonNumpadDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.TextBox textBoxCZ;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.TextBox textBoxNomBDDMYSQL;
        private System.Windows.Forms.TextBox textBoxMotdepasseMYSQL;
        private System.Windows.Forms.TextBox textBoxUsernameMYSQL;
        private System.Windows.Forms.TextBox textBoxAdresseMYSQL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboxBoxChoixPortSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BoutonRechargerPortSerie;
        private System.Windows.Forms.Button buttonArreterLiaisonSerie;
        private System.Windows.Forms.Button buttonDemarrerLiaisonSerie;
        private System.Windows.Forms.TextBox textBoxEtatLiaisonSerie;
        private System.Windows.Forms.Label label12;
    }
}