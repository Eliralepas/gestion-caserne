namespace UC_GestionPerso
{
    partial class GestionPerso
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            flpCaserne = new FlowLayoutPanel();
            flpPompier = new FlowLayoutPanel();
            pnlInfo = new Panel();
            btnModif = new Button();
            lblMatricule = new Label();
            grpCaserne = new GroupBox();
            chbConge = new CheckBox();
            cboCaserne = new ComboBox();
            cboGrade = new ComboBox();
            txtGradeCode = new TextBox();
            rtbAffec = new RichTextBox();
            label11 = new Label();
            rtbHab = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            btnChanger = new Button();
            grpContact = new GroupBox();
            lblBip = new Label();
            lblTel = new Label();
            pic = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            grpIdentite = new GroupBox();
            lblDateEmbauche = new Label();
            lblDateNaissance = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblSexe = new Label();
            label12 = new Label();
            rdbVolontaire = new RadioButton();
            rdbPro = new RadioButton();
            label4 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnInfo = new Button();
            btnCreate = new Button();
            pnlInfo.SuspendLayout();
            grpCaserne.SuspendLayout();
            grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            grpIdentite.SuspendLayout();
            SuspendLayout();
            // 
            // flpCaserne
            // 
            flpCaserne.AutoScroll = true;
            flpCaserne.BackColor = SystemColors.MenuHighlight;
            flpCaserne.FlowDirection = FlowDirection.TopDown;
            flpCaserne.Location = new Point(5, 5);
            flpCaserne.Margin = new Padding(5);
            flpCaserne.Name = "flpCaserne";
            flpCaserne.Size = new Size(222, 541);
            flpCaserne.TabIndex = 0;
            flpCaserne.WrapContents = false;
            // 
            // flpPompier
            // 
            flpPompier.AllowDrop = true;
            flpPompier.AutoScroll = true;
            flpPompier.BackColor = Color.FromArgb(224, 224, 224);
            flpPompier.ForeColor = Color.Black;
            flpPompier.Location = new Point(237, 5);
            flpPompier.Margin = new Padding(5);
            flpPompier.Name = "flpPompier";
            flpPompier.Size = new Size(285, 627);
            flpPompier.TabIndex = 1;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.Red;
            pnlInfo.Controls.Add(btnModif);
            pnlInfo.Controls.Add(lblMatricule);
            pnlInfo.Controls.Add(grpCaserne);
            pnlInfo.Controls.Add(btnChanger);
            pnlInfo.Controls.Add(grpContact);
            pnlInfo.Controls.Add(grpIdentite);
            pnlInfo.Controls.Add(btnInfo);
            pnlInfo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlInfo.Location = new Point(532, 5);
            pnlInfo.Margin = new Padding(5);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(562, 624);
            pnlInfo.TabIndex = 2;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(133, 590);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(156, 31);
            btnModif.TabIndex = 21;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Visible = false;
            btnModif.Click += btnModif_Click;
            // 
            // lblMatricule
            // 
            lblMatricule.AutoSize = true;
            lblMatricule.Font = new Font("Arial", 14F);
            lblMatricule.ForeColor = Color.Black;
            lblMatricule.Location = new Point(174, 0);
            lblMatricule.Name = "lblMatricule";
            lblMatricule.Size = new Size(90, 22);
            lblMatricule.TabIndex = 19;
            lblMatricule.Text = "Matricule ";
            lblMatricule.Visible = false;
            // 
            // grpCaserne
            // 
            grpCaserne.Controls.Add(chbConge);
            grpCaserne.Controls.Add(cboCaserne);
            grpCaserne.Controls.Add(cboGrade);
            grpCaserne.Controls.Add(txtGradeCode);
            grpCaserne.Controls.Add(rtbAffec);
            grpCaserne.Controls.Add(label11);
            grpCaserne.Controls.Add(rtbHab);
            grpCaserne.Controls.Add(label10);
            grpCaserne.Controls.Add(label9);
            grpCaserne.Controls.Add(label7);
            grpCaserne.Font = new Font("Arial", 13F);
            grpCaserne.ForeColor = SystemColors.ControlText;
            grpCaserne.Location = new Point(14, 325);
            grpCaserne.Name = "grpCaserne";
            grpCaserne.Size = new Size(479, 259);
            grpCaserne.TabIndex = 1;
            grpCaserne.TabStop = false;
            grpCaserne.Text = " Carrière";
            grpCaserne.Visible = false;
            // 
            // chbConge
            // 
            chbConge.AutoSize = true;
            chbConge.Enabled = false;
            chbConge.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            chbConge.Location = new Point(10, 226);
            chbConge.Name = "chbConge";
            chbConge.Size = new Size(100, 27);
            chbConge.TabIndex = 26;
            chbConge.Text = "en congé";
            chbConge.UseVisualStyleBackColor = true;
            // 
            // cboCaserne
            // 
            cboCaserne.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCaserne.Enabled = false;
            cboCaserne.Font = new Font("Arial", 9F);
            cboCaserne.FormattingEnabled = true;
            cboCaserne.Location = new Point(211, 69);
            cboCaserne.Name = "cboCaserne";
            cboCaserne.Size = new Size(255, 23);
            cboCaserne.TabIndex = 25;
            // 
            // cboGrade
            // 
            cboGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrade.Enabled = false;
            cboGrade.Font = new Font("Arial", 9F);
            cboGrade.FormattingEnabled = true;
            cboGrade.Location = new Point(211, 36);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(255, 23);
            cboGrade.TabIndex = 24;
            cboGrade.SelectedIndexChanged += cboGrade_SelectedIndexChanged;
            // 
            // txtGradeCode
            // 
            txtGradeCode.Enabled = false;
            txtGradeCode.Font = new Font("Arial", 9F);
            txtGradeCode.Location = new Point(94, 40);
            txtGradeCode.Name = "txtGradeCode";
            txtGradeCode.ReadOnly = true;
            txtGradeCode.Size = new Size(91, 21);
            txtGradeCode.TabIndex = 19;
            // 
            // rtbAffec
            // 
            rtbAffec.Font = new Font("Arial", 9F);
            rtbAffec.Location = new Point(211, 169);
            rtbAffec.Name = "rtbAffec";
            rtbAffec.ReadOnly = true;
            rtbAffec.Size = new Size(255, 59);
            rtbAffec.TabIndex = 23;
            rtbAffec.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(10, 169);
            label11.Name = "label11";
            label11.Size = new Size(169, 23);
            label11.TabIndex = 22;
            label11.Text = "Affectations passés :";
            // 
            // rtbHab
            // 
            rtbHab.Font = new Font("Arial", 9F);
            rtbHab.Location = new Point(211, 104);
            rtbHab.Name = "rtbHab";
            rtbHab.ReadOnly = true;
            rtbHab.Size = new Size(255, 59);
            rtbHab.TabIndex = 21;
            rtbHab.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(6, 104);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 20;
            label10.Text = "Habilitations :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(5, 69);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 19;
            label9.Text = "Caserne : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 18;
            label7.Text = "Grade :";
            // 
            // btnChanger
            // 
            btnChanger.Font = new Font("Arial", 10F);
            btnChanger.ForeColor = SystemColors.ControlText;
            btnChanger.Location = new Point(342, 590);
            btnChanger.Name = "btnChanger";
            btnChanger.Size = new Size(138, 32);
            btnChanger.TabIndex = 20;
            btnChanger.Text = "Mettre à jour";
            btnChanger.UseVisualStyleBackColor = true;
            btnChanger.Visible = false;
            btnChanger.Click += btnChanger_Click;
            // 
            // grpContact
            // 
            grpContact.Controls.Add(lblBip);
            grpContact.Controls.Add(lblTel);
            grpContact.Controls.Add(pic);
            grpContact.Controls.Add(label6);
            grpContact.Controls.Add(label5);
            grpContact.Font = new Font("Arial", 13F);
            grpContact.ForeColor = SystemColors.ControlText;
            grpContact.Location = new Point(278, 31);
            grpContact.Name = "grpContact";
            grpContact.Size = new Size(215, 250);
            grpContact.TabIndex = 15;
            grpContact.TabStop = false;
            grpContact.Text = "Contact";
            grpContact.Visible = false;
            // 
            // lblBip
            // 
            lblBip.AutoSize = true;
            lblBip.Font = new Font("Arial", 10F);
            lblBip.ForeColor = Color.Black;
            lblBip.Location = new Point(50, 219);
            lblBip.Name = "lblBip";
            lblBip.Size = new Size(11, 16);
            lblBip.TabIndex = 27;
            lblBip.Text = ".";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Arial", 10F);
            lblTel.ForeColor = Color.Black;
            lblTel.Location = new Point(50, 168);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(11, 16);
            lblTel.TabIndex = 26;
            lblTel.Text = ".";
            // 
            // pic
            // 
            pic.Location = new Point(50, 26);
            pic.Name = "pic";
            pic.Size = new Size(106, 89);
            pic.TabIndex = 12;
            pic.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(50, 196);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 11;
            label6.Text = "Bip :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(50, 131);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 10;
            label5.Text = "Téléphone : ";
            // 
            // grpIdentite
            // 
            grpIdentite.Controls.Add(lblDateEmbauche);
            grpIdentite.Controls.Add(lblDateNaissance);
            grpIdentite.Controls.Add(lblNom);
            grpIdentite.Controls.Add(lblPrenom);
            grpIdentite.Controls.Add(lblSexe);
            grpIdentite.Controls.Add(label12);
            grpIdentite.Controls.Add(rdbVolontaire);
            grpIdentite.Controls.Add(rdbPro);
            grpIdentite.Controls.Add(label4);
            grpIdentite.Controls.Add(label8);
            grpIdentite.Controls.Add(label2);
            grpIdentite.Controls.Add(label3);
            grpIdentite.Controls.Add(label1);
            grpIdentite.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpIdentite.ForeColor = SystemColors.ControlText;
            grpIdentite.Location = new Point(14, 31);
            grpIdentite.Name = "grpIdentite";
            grpIdentite.Size = new Size(246, 288);
            grpIdentite.TabIndex = 0;
            grpIdentite.TabStop = false;
            grpIdentite.Text = "Identité";
            grpIdentite.Visible = false;
            // 
            // lblDateEmbauche
            // 
            lblDateEmbauche.AutoSize = true;
            lblDateEmbauche.Font = new Font("Arial", 10F);
            lblDateEmbauche.ForeColor = Color.Black;
            lblDateEmbauche.Location = new Point(110, 178);
            lblDateEmbauche.Name = "lblDateEmbauche";
            lblDateEmbauche.Size = new Size(11, 16);
            lblDateEmbauche.TabIndex = 25;
            lblDateEmbauche.Text = ".";
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Font = new Font("Arial", 10F);
            lblDateNaissance.ForeColor = Color.Black;
            lblDateNaissance.Location = new Point(94, 138);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new Size(11, 16);
            lblDateNaissance.TabIndex = 24;
            lblDateNaissance.Text = ".";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Arial", 10F);
            lblNom.ForeColor = Color.Black;
            lblNom.Location = new Point(94, 33);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(11, 16);
            lblNom.TabIndex = 23;
            lblNom.Text = ".";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Arial", 10F);
            lblPrenom.ForeColor = Color.Black;
            lblPrenom.Location = new Point(94, 66);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(11, 16);
            lblPrenom.TabIndex = 22;
            lblPrenom.Text = ".";
            // 
            // lblSexe
            // 
            lblSexe.AutoSize = true;
            lblSexe.Font = new Font("Arial", 10F);
            lblSexe.ForeColor = Color.Black;
            lblSexe.Location = new Point(94, 102);
            lblSexe.Name = "lblSexe";
            lblSexe.Size = new Size(11, 16);
            lblSexe.TabIndex = 21;
            lblSexe.Text = ".";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(6, 178);
            label12.Name = "label12";
            label12.Size = new Size(121, 23);
            label12.TabIndex = 19;
            label12.Text = "Embauché le : ";
            // 
            // rdbVolontaire
            // 
            rdbVolontaire.AutoSize = true;
            rdbVolontaire.Enabled = false;
            rdbVolontaire.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            rdbVolontaire.ForeColor = Color.Black;
            rdbVolontaire.Location = new Point(94, 252);
            rdbVolontaire.Name = "rdbVolontaire";
            rdbVolontaire.Size = new Size(105, 27);
            rdbVolontaire.TabIndex = 14;
            rdbVolontaire.TabStop = true;
            rdbVolontaire.Text = "Volontaire";
            rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbPro
            // 
            rdbPro.AutoSize = true;
            rdbPro.Enabled = false;
            rdbPro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            rdbPro.ForeColor = Color.Black;
            rdbPro.Location = new Point(94, 219);
            rdbPro.Name = "rdbPro";
            rdbPro.Size = new Size(123, 27);
            rdbPro.TabIndex = 13;
            rdbPro.TabStop = true;
            rdbPro.Text = "Professionel";
            rdbPro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 218);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 10;
            label4.Text = "Status :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(6, 138);
            label8.Name = "label8";
            label8.Size = new Size(60, 23);
            label8.TabIndex = 9;
            label8.Text = "Né le : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 102);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 4;
            label2.Text = "Sexe :  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 3;
            label3.Text = "Prénom : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Nom : ";
            // 
            // btnInfo
            // 
            btnInfo.Font = new Font("Arial", 10F);
            btnInfo.ForeColor = SystemColors.GrayText;
            btnInfo.Location = new Point(285, 287);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(195, 32);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Plus d'informations";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Visible = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 554);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(224, 71);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Nouveau Pompier";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // UCGestionPerso
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreate);
            Controls.Add(pnlInfo);
            Controls.Add(flpPompier);
            Controls.Add(flpCaserne);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(5);
            Name = "UCGestionPerso";
            Size = new Size(1099, 641);
            Load += UCGestionPerso_Load;
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            grpCaserne.ResumeLayout(false);
            grpCaserne.PerformLayout();
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            grpIdentite.ResumeLayout(false);
            grpIdentite.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCaserne;
        private System.Windows.Forms.FlowLayoutPanel flpPompier;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpCaserne;
        private System.Windows.Forms.GroupBox grpIdentite;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbHab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.RichTextBox rtbAffec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtGradeCode;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.CheckBox chbConge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTel;
        private Button btnModif;
    }
}
