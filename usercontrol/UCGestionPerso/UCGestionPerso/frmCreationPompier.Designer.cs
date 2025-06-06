namespace UCGestionPerso
{
    partial class frmCreationPompier
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
            this.components = new System.ComponentModel.Container();
            this.pnlIdentite = new System.Windows.Forms.Panel();
            this.lblBipA = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.dtpN = new System.Windows.Forms.DateTimePicker();
            this.lblDateN = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlCarriere = new System.Windows.Forms.Panel();
            this.btnAnnulDateF = new System.Windows.Forms.Button();
            this.btnDateF = new System.Windows.Forms.Button();
            this.grpEmbauche = new System.Windows.Forms.GroupBox();
            this.dtpC = new System.Windows.Forms.DateTimePicker();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBip = new System.Windows.Forms.Label();
            this.pnlIdentite.SuspendLayout();
            this.pnlCarriere.SuspendLayout();
            this.grpEmbauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIdentite
            // 
            this.pnlIdentite.BackColor = System.Drawing.Color.DarkRed;
            this.pnlIdentite.Controls.Add(this.lblBip);
            this.pnlIdentite.Controls.Add(this.lblBipA);
            this.pnlIdentite.Controls.Add(this.txtTel);
            this.pnlIdentite.Controls.Add(this.lblTel);
            this.pnlIdentite.Controls.Add(this.dtpN);
            this.pnlIdentite.Controls.Add(this.lblDateN);
            this.pnlIdentite.Controls.Add(this.txtPrenom);
            this.pnlIdentite.Controls.Add(this.txtNom);
            this.pnlIdentite.Controls.Add(this.rdbFemme);
            this.pnlIdentite.Controls.Add(this.rdbHomme);
            this.pnlIdentite.Controls.Add(this.lblSexe);
            this.pnlIdentite.Controls.Add(this.lblPrenom);
            this.pnlIdentite.Controls.Add(this.lblNom);
            this.pnlIdentite.Font = new System.Drawing.Font("Arial", 12F);
            this.pnlIdentite.Location = new System.Drawing.Point(12, 70);
            this.pnlIdentite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIdentite.Name = "pnlIdentite";
            this.pnlIdentite.Size = new System.Drawing.Size(429, 432);
            this.pnlIdentite.TabIndex = 0;
            // 
            // lblBipA
            // 
            this.lblBipA.AutoSize = true;
            this.lblBipA.Location = new System.Drawing.Point(25, 378);
            this.lblBipA.Name = "lblBipA";
            this.lblBipA.Size = new System.Drawing.Size(61, 27);
            this.lblBipA.TabIndex = 12;
            this.lblBipA.Text = "Bip :";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTel.Location = new System.Drawing.Point(173, 314);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.ShortcutsEnabled = false;
            this.txtTel.Size = new System.Drawing.Size(223, 33);
            this.txtTel.TabIndex = 11;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(25, 320);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(147, 27);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Téléphone : ";
            // 
            // dtpN
            // 
            this.dtpN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpN.Location = new System.Drawing.Point(173, 250);
            this.dtpN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpN.MaxDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtpN.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpN.Name = "dtpN";
            this.dtpN.Size = new System.Drawing.Size(223, 35);
            this.dtpN.TabIndex = 9;
            this.dtpN.Value = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateN
            // 
            this.lblDateN.AutoSize = true;
            this.lblDateN.Location = new System.Drawing.Point(25, 258);
            this.lblDateN.Name = "lblDateN";
            this.lblDateN.Size = new System.Drawing.Size(98, 27);
            this.lblDateN.TabIndex = 8;
            this.lblDateN.Text = "Né le* : ";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPrenom.Location = new System.Drawing.Point(173, 82);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ShortcutsEnabled = false;
            this.txtPrenom.Size = new System.Drawing.Size(223, 33);
            this.txtPrenom.TabIndex = 7;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNom.Location = new System.Drawing.Point(173, 22);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.ShortcutsEnabled = false;
            this.txtNom.Size = new System.Drawing.Size(223, 33);
            this.txtNom.TabIndex = 6;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Location = new System.Drawing.Point(173, 184);
            this.rdbFemme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(118, 31);
            this.rdbFemme.TabIndex = 5;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Location = new System.Drawing.Point(173, 148);
            this.rdbHomme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(120, 31);
            this.rdbHomme.TabIndex = 4;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(25, 148);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(88, 27);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe* :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(25, 88);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(119, 27);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom* :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(25, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(85, 27);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom* :";
            // 
            // pnlCarriere
            // 
            this.pnlCarriere.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCarriere.Controls.Add(this.btnAnnulDateF);
            this.pnlCarriere.Controls.Add(this.btnDateF);
            this.pnlCarriere.Controls.Add(this.grpEmbauche);
            this.pnlCarriere.Controls.Add(this.cboGrade);
            this.pnlCarriere.Controls.Add(this.rdbVolontaire);
            this.pnlCarriere.Controls.Add(this.lblType);
            this.pnlCarriere.Controls.Add(this.rdbPro);
            this.pnlCarriere.Controls.Add(this.lblGrade);
            this.pnlCarriere.Font = new System.Drawing.Font("Arial", 12F);
            this.pnlCarriere.Location = new System.Drawing.Point(469, 70);
            this.pnlCarriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCarriere.Name = "pnlCarriere";
            this.pnlCarriere.Size = new System.Drawing.Size(429, 432);
            this.pnlCarriere.TabIndex = 1;
            // 
            // btnAnnulDateF
            // 
            this.btnAnnulDateF.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAnnulDateF.Location = new System.Drawing.Point(19, 371);
            this.btnAnnulDateF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnulDateF.Name = "btnAnnulDateF";
            this.btnAnnulDateF.Size = new System.Drawing.Size(291, 42);
            this.btnAnnulDateF.TabIndex = 20;
            this.btnAnnulDateF.Text = "Ne pas rajouter de date fin";
            this.btnAnnulDateF.UseVisualStyleBackColor = true;
            this.btnAnnulDateF.Visible = false;
            this.btnAnnulDateF.Click += new System.EventHandler(this.btnAnnulDateF_Click);
            // 
            // btnDateF
            // 
            this.btnDateF.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDateF.Location = new System.Drawing.Point(19, 370);
            this.btnDateF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDateF.Name = "btnDateF";
            this.btnDateF.Size = new System.Drawing.Size(290, 42);
            this.btnDateF.TabIndex = 4;
            this.btnDateF.Text = "Ajout de la date fin";
            this.btnDateF.UseVisualStyleBackColor = true;
            this.btnDateF.Click += new System.EventHandler(this.btnDateF_Click);
            // 
            // grpEmbauche
            // 
            this.grpEmbauche.Controls.Add(this.dtpC);
            this.grpEmbauche.Controls.Add(this.cboCaserne);
            this.grpEmbauche.Controls.Add(this.lblCaserne);
            this.grpEmbauche.Controls.Add(this.lblDateFin);
            this.grpEmbauche.Location = new System.Drawing.Point(18, 184);
            this.grpEmbauche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmbauche.Name = "grpEmbauche";
            this.grpEmbauche.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmbauche.Size = new System.Drawing.Size(397, 162);
            this.grpEmbauche.TabIndex = 19;
            this.grpEmbauche.TabStop = false;
            this.grpEmbauche.Text = "Affectation à une caserne";
            // 
            // dtpC
            // 
            this.dtpC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpC.Location = new System.Drawing.Point(136, 104);
            this.dtpC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpC.MaxDate = new System.DateTime(2051, 1, 1, 0, 0, 0, 0);
            this.dtpC.MinDate = new System.DateTime(2025, 6, 7, 0, 0, 0, 0);
            this.dtpC.Name = "dtpC";
            this.dtpC.Size = new System.Drawing.Size(254, 35);
            this.dtpC.TabIndex = 15;
            this.dtpC.Value = new System.DateTime(2025, 6, 7, 0, 0, 0, 0);
            this.dtpC.Visible = false;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(136, 49);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(254, 35);
            this.cboCaserne.TabIndex = 18;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(6, 52);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(132, 27);
            this.lblCaserne.TabIndex = 17;
            this.lblCaserne.Text = "Caserne* : ";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(7, 111);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(93, 27);
            this.lblDateFin.TabIndex = 14;
            this.lblDateFin.Text = "Fin le : ";
            this.lblDateFin.Visible = false;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(154, 120);
            this.cboGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(254, 35);
            this.cboGrade.TabIndex = 16;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Location = new System.Drawing.Point(154, 66);
            this.rdbVolontaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(143, 31);
            this.rdbVolontaire.TabIndex = 15;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(87, 27);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type* :";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Location = new System.Drawing.Point(154, 29);
            this.rdbPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(169, 31);
            this.rdbPro.TabIndex = 14;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(24, 124);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(102, 27);
            this.lblGrade.TabIndex = 14;
            this.lblGrade.Text = "Grade* :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatricule.Location = new System.Drawing.Point(336, 19);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(151, 29);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule n°";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Arial", 12F);
            this.btnValider.Location = new System.Drawing.Point(554, 512);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(169, 42);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Créer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(731, 512);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(166, 42);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(168, 378);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(19, 27);
            this.lblBip.TabIndex = 14;
            this.lblBip.Text = ".";
            // 
            // frmCreationPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(910, 569);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.pnlCarriere);
            this.Controls.Add(this.pnlIdentite);
            this.Controls.Add(this.lblMatricule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreationPompier";
            this.Text = "frmCreationPompier";
            this.Load += new System.EventHandler(this.frmCreationPompier_Load);
            this.pnlIdentite.ResumeLayout(false);
            this.pnlIdentite.PerformLayout();
            this.pnlCarriere.ResumeLayout(false);
            this.pnlCarriere.PerformLayout();
            this.grpEmbauche.ResumeLayout(false);
            this.grpEmbauche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIdentite;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Panel pnlCarriere;
        private System.Windows.Forms.DateTimePicker dtpN;
        private System.Windows.Forms.Label lblDateN;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblBipA;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.DateTimePicker dtpC;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.GroupBox grpEmbauche;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnDateF;
        private System.Windows.Forms.Button btnAnnulDateF;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblBip;
    }
}