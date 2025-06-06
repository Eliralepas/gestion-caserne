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
            this.pnlIdentite = new System.Windows.Forms.Panel();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateN = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlCarriere = new System.Windows.Forms.Panel();
            this.grpEmbauche = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.pnlIdentite.SuspendLayout();
            this.pnlCarriere.SuspendLayout();
            this.grpEmbauche.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIdentite
            // 
            this.pnlIdentite.BackColor = System.Drawing.Color.DarkRed;
            this.pnlIdentite.Controls.Add(this.txtBip);
            this.pnlIdentite.Controls.Add(this.lblBip);
            this.pnlIdentite.Controls.Add(this.txtTel);
            this.pnlIdentite.Controls.Add(this.lblTel);
            this.pnlIdentite.Controls.Add(this.dateTimePicker1);
            this.pnlIdentite.Controls.Add(this.lblDateN);
            this.pnlIdentite.Controls.Add(this.txtPrenom);
            this.pnlIdentite.Controls.Add(this.txtNom);
            this.pnlIdentite.Controls.Add(this.rdbFemme);
            this.pnlIdentite.Controls.Add(this.rdbHomme);
            this.pnlIdentite.Controls.Add(this.lblSexe);
            this.pnlIdentite.Controls.Add(this.lblPrenom);
            this.pnlIdentite.Controls.Add(this.lblNom);
            this.pnlIdentite.Font = new System.Drawing.Font("Arial", 12F);
            this.pnlIdentite.Location = new System.Drawing.Point(11, 56);
            this.pnlIdentite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIdentite.Name = "pnlIdentite";
            this.pnlIdentite.Size = new System.Drawing.Size(381, 346);
            this.pnlIdentite.TabIndex = 0;
            // 
            // txtBip
            // 
            this.txtBip.BackColor = System.Drawing.Color.DarkRed;
            this.txtBip.Font = new System.Drawing.Font("Arial", 11F);
            this.txtBip.Location = new System.Drawing.Point(154, 297);
            this.txtBip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBip.Name = "txtBip";
            this.txtBip.Size = new System.Drawing.Size(132, 29);
            this.txtBip.TabIndex = 13;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(22, 302);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(50, 23);
            this.lblBip.TabIndex = 12;
            this.lblBip.Text = "Bip :";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTel.Location = new System.Drawing.Point(154, 251);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.ShortcutsEnabled = false;
            this.txtTel.Size = new System.Drawing.Size(199, 29);
            this.txtTel.TabIndex = 11;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(22, 256);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(119, 23);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Téléphone : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 200);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 30);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            // 
            // lblDateN
            // 
            this.lblDateN.AutoSize = true;
            this.lblDateN.Location = new System.Drawing.Point(22, 206);
            this.lblDateN.Name = "lblDateN";
            this.lblDateN.Size = new System.Drawing.Size(81, 23);
            this.lblDateN.TabIndex = 8;
            this.lblDateN.Text = "Né le* : ";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPrenom.Location = new System.Drawing.Point(154, 66);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ShortcutsEnabled = false;
            this.txtPrenom.Size = new System.Drawing.Size(199, 29);
            this.txtPrenom.TabIndex = 7;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNom.Location = new System.Drawing.Point(154, 18);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.ShortcutsEnabled = false;
            this.txtNom.Size = new System.Drawing.Size(199, 29);
            this.txtNom.TabIndex = 6;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Location = new System.Drawing.Point(154, 147);
            this.rdbFemme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(97, 27);
            this.rdbFemme.TabIndex = 5;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.Location = new System.Drawing.Point(154, 118);
            this.rdbHomme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(98, 27);
            this.rdbHomme.TabIndex = 4;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(22, 118);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(74, 23);
            this.lblSexe.TabIndex = 3;
            this.lblSexe.Text = "Sexe* :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(22, 70);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(98, 23);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom* :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(22, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(70, 23);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom* :";
            // 
            // pnlCarriere
            // 
            this.pnlCarriere.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCarriere.Controls.Add(this.grpEmbauche);
            this.pnlCarriere.Controls.Add(this.cboGrade);
            this.pnlCarriere.Controls.Add(this.rdbVolontaire);
            this.pnlCarriere.Controls.Add(this.lblType);
            this.pnlCarriere.Controls.Add(this.rdbPro);
            this.pnlCarriere.Controls.Add(this.lblGrade);
            this.pnlCarriere.Font = new System.Drawing.Font("Arial", 12F);
            this.pnlCarriere.Location = new System.Drawing.Point(417, 56);
            this.pnlCarriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCarriere.Name = "pnlCarriere";
            this.pnlCarriere.Size = new System.Drawing.Size(381, 297);
            this.pnlCarriere.TabIndex = 1;
            // 
            // grpEmbauche
            // 
            this.grpEmbauche.Controls.Add(this.dateTimePicker2);
            this.grpEmbauche.Controls.Add(this.cboCaserne);
            this.grpEmbauche.Controls.Add(this.lblCaserne);
            this.grpEmbauche.Controls.Add(this.lblDateFin);
            this.grpEmbauche.Location = new System.Drawing.Point(16, 147);
            this.grpEmbauche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmbauche.Name = "grpEmbauche";
            this.grpEmbauche.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmbauche.Size = new System.Drawing.Size(353, 130);
            this.grpEmbauche.TabIndex = 19;
            this.grpEmbauche.TabStop = false;
            this.grpEmbauche.Text = "Affectation à une caserne";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 86);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.MaxDate = new System.DateTime(2051, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2025, 6, 5, 0, 0, 0, 0);
            this.dateTimePicker2.Visible = false;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(133, 35);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(204, 31);
            this.cboCaserne.TabIndex = 18;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(5, 42);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(110, 23);
            this.lblCaserne.TabIndex = 17;
            this.lblCaserne.Text = "Caserne* : ";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(5, 89);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(75, 23);
            this.lblDateFin.TabIndex = 14;
            this.lblDateFin.Text = "Fin le : ";
            this.lblDateFin.Visible = false;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(149, 97);
            this.cboGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(204, 31);
            this.cboGrade.TabIndex = 16;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Location = new System.Drawing.Point(149, 53);
            this.rdbVolontaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(118, 27);
            this.rdbVolontaire.TabIndex = 15;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(21, 23);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 23);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type* :";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Location = new System.Drawing.Point(149, 23);
            this.rdbPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(139, 27);
            this.rdbPro.TabIndex = 14;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(21, 99);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(86, 23);
            this.lblGrade.TabIndex = 14;
            this.lblGrade.Text = "Grade* :";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatricule.Location = new System.Drawing.Point(299, 15);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(123, 24);
            this.lblMatricule.TabIndex = 0;
            this.lblMatricule.Text = "Matricule n°";
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Arial", 12F);
            this.btnValider.Location = new System.Drawing.Point(442, 372);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(150, 34);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Créer";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAnnuler.Location = new System.Drawing.Point(622, 372);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(148, 34);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmCreationPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(809, 417);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.pnlCarriere);
            this.Controls.Add(this.pnlIdentite);
            this.Controls.Add(this.lblMatricule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreationPompier";
            this.Text = "frmCreationPompier";
            this.pnlIdentite.ResumeLayout(false);
            this.pnlIdentite.PerformLayout();
            this.pnlCarriere.ResumeLayout(false);
            this.pnlCarriere.PerformLayout();
            this.grpEmbauche.ResumeLayout(false);
            this.grpEmbauche.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateN;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.GroupBox grpEmbauche;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}