namespace UCGestionPerso
{
    partial class UCGestionPerso
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
            this.flpCaserne = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPompier = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.grpCaserne = new System.Windows.Forms.GroupBox();
            this.chbConge = new System.Windows.Forms.CheckBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.txtGradeCode = new System.Windows.Forms.TextBox();
            this.rtbAffec = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbHab = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpIdentite = new System.Windows.Forms.GroupBox();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.grpCaserne.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.grpIdentite.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCaserne
            // 
            this.flpCaserne.AutoScroll = true;
            this.flpCaserne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpCaserne.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCaserne.Location = new System.Drawing.Point(5, 5);
            this.flpCaserne.Margin = new System.Windows.Forms.Padding(5);
            this.flpCaserne.Name = "flpCaserne";
            this.flpCaserne.Size = new System.Drawing.Size(211, 541);
            this.flpCaserne.TabIndex = 0;
            this.flpCaserne.WrapContents = false;
            // 
            // flpPompier
            // 
            this.flpPompier.AllowDrop = true;
            this.flpPompier.AutoScroll = true;
            this.flpPompier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flpPompier.Location = new System.Drawing.Point(226, 5);
            this.flpPompier.Margin = new System.Windows.Forms.Padding(5);
            this.flpPompier.Name = "flpPompier";
            this.flpPompier.Size = new System.Drawing.Size(239, 620);
            this.flpPompier.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Red;
            this.pnlInfo.Controls.Add(this.lblMatricule);
            this.pnlInfo.Controls.Add(this.grpCaserne);
            this.pnlInfo.Controls.Add(this.btnChanger);
            this.pnlInfo.Controls.Add(this.grpContact);
            this.pnlInfo.Controls.Add(this.grpIdentite);
            this.pnlInfo.Controls.Add(this.btnInfo);
            this.pnlInfo.Location = new System.Drawing.Point(475, 5);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(510, 620);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMatricule.ForeColor = System.Drawing.Color.Black;
            this.lblMatricule.Location = new System.Drawing.Point(174, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(116, 27);
            this.lblMatricule.TabIndex = 19;
            this.lblMatricule.Text = "Matricule ";
            this.lblMatricule.Visible = false;
            // 
            // grpCaserne
            // 
            this.grpCaserne.Controls.Add(this.chbConge);
            this.grpCaserne.Controls.Add(this.cboCaserne);
            this.grpCaserne.Controls.Add(this.cboGrade);
            this.grpCaserne.Controls.Add(this.txtGradeCode);
            this.grpCaserne.Controls.Add(this.rtbAffec);
            this.grpCaserne.Controls.Add(this.label11);
            this.grpCaserne.Controls.Add(this.rtbHab);
            this.grpCaserne.Controls.Add(this.label10);
            this.grpCaserne.Controls.Add(this.label9);
            this.grpCaserne.Controls.Add(this.label7);
            this.grpCaserne.Font = new System.Drawing.Font("Arial", 13F);
            this.grpCaserne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpCaserne.Location = new System.Drawing.Point(14, 325);
            this.grpCaserne.Name = "grpCaserne";
            this.grpCaserne.Size = new System.Drawing.Size(479, 259);
            this.grpCaserne.TabIndex = 1;
            this.grpCaserne.TabStop = false;
            this.grpCaserne.Text = " Carrière";
            this.grpCaserne.Visible = false;
            // 
            // chbConge
            // 
            this.chbConge.AutoSize = true;
            this.chbConge.Enabled = false;
            this.chbConge.Font = new System.Drawing.Font("Arial", 10F);
            this.chbConge.Location = new System.Drawing.Point(10, 226);
            this.chbConge.Name = "chbConge";
            this.chbConge.Size = new System.Drawing.Size(99, 23);
            this.chbConge.TabIndex = 26;
            this.chbConge.Text = "en congé";
            this.chbConge.UseVisualStyleBackColor = true;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.Enabled = false;
            this.cboCaserne.Font = new System.Drawing.Font("Arial", 9F);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(211, 69);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(255, 25);
            this.cboCaserne.TabIndex = 25;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Enabled = false;
            this.cboGrade.Font = new System.Drawing.Font("Arial", 9F);
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(211, 36);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(255, 25);
            this.cboGrade.TabIndex = 24;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // txtGradeCode
            // 
            this.txtGradeCode.Enabled = false;
            this.txtGradeCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txtGradeCode.Location = new System.Drawing.Point(98, 37);
            this.txtGradeCode.Name = "txtGradeCode";
            this.txtGradeCode.ReadOnly = true;
            this.txtGradeCode.Size = new System.Drawing.Size(91, 25);
            this.txtGradeCode.TabIndex = 19;
            // 
            // rtbAffec
            // 
            this.rtbAffec.Font = new System.Drawing.Font("Arial", 9F);
            this.rtbAffec.Location = new System.Drawing.Point(211, 169);
            this.rtbAffec.Name = "rtbAffec";
            this.rtbAffec.ReadOnly = true;
            this.rtbAffec.Size = new System.Drawing.Size(255, 59);
            this.rtbAffec.TabIndex = 23;
            this.rtbAffec.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Affectations passés :";
            // 
            // rtbHab
            // 
            this.rtbHab.Font = new System.Drawing.Font("Arial", 9F);
            this.rtbHab.Location = new System.Drawing.Point(211, 104);
            this.rtbHab.Name = "rtbHab";
            this.rtbHab.ReadOnly = true;
            this.rtbHab.Size = new System.Drawing.Size(255, 59);
            this.rtbHab.TabIndex = 21;
            this.rtbHab.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Habilitations :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Caserne : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grade :";
            // 
            // btnChanger
            // 
            this.btnChanger.Font = new System.Drawing.Font("Arial", 10F);
            this.btnChanger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChanger.Location = new System.Drawing.Point(349, 585);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(138, 32);
            this.btnChanger.TabIndex = 20;
            this.btnChanger.Text = "Mettre à jour";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Visible = false;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.lblBip);
            this.grpContact.Controls.Add(this.lblTel);
            this.grpContact.Controls.Add(this.pic);
            this.grpContact.Controls.Add(this.label6);
            this.grpContact.Controls.Add(this.label5);
            this.grpContact.Font = new System.Drawing.Font("Arial", 13F);
            this.grpContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpContact.Location = new System.Drawing.Point(278, 31);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(215, 250);
            this.grpContact.TabIndex = 15;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            this.grpContact.Visible = false;
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBip.ForeColor = System.Drawing.Color.Black;
            this.lblBip.Location = new System.Drawing.Point(50, 219);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(14, 19);
            this.lblBip.TabIndex = 27;
            this.lblBip.Text = ".";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(50, 168);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(14, 19);
            this.lblTel.TabIndex = 26;
            this.lblTel.Text = ".";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(54, 33);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(114, 101);
            this.pic.TabIndex = 12;
            this.pic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bip :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Téléphone : ";
            // 
            // grpIdentite
            // 
            this.grpIdentite.Controls.Add(this.lblDateEmbauche);
            this.grpIdentite.Controls.Add(this.lblDateNaissance);
            this.grpIdentite.Controls.Add(this.lblNom);
            this.grpIdentite.Controls.Add(this.lblPrenom);
            this.grpIdentite.Controls.Add(this.lblSexe);
            this.grpIdentite.Controls.Add(this.label12);
            this.grpIdentite.Controls.Add(this.rdbVolontaire);
            this.grpIdentite.Controls.Add(this.rdbPro);
            this.grpIdentite.Controls.Add(this.label4);
            this.grpIdentite.Controls.Add(this.label8);
            this.grpIdentite.Controls.Add(this.label2);
            this.grpIdentite.Controls.Add(this.label3);
            this.grpIdentite.Controls.Add(this.label1);
            this.grpIdentite.Font = new System.Drawing.Font("Arial", 13F);
            this.grpIdentite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpIdentite.Location = new System.Drawing.Point(14, 31);
            this.grpIdentite.Name = "grpIdentite";
            this.grpIdentite.Size = new System.Drawing.Size(246, 288);
            this.grpIdentite.TabIndex = 0;
            this.grpIdentite.TabStop = false;
            this.grpIdentite.Text = "Identité";
            this.grpIdentite.Visible = false;
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateEmbauche.ForeColor = System.Drawing.Color.Black;
            this.lblDateEmbauche.Location = new System.Drawing.Point(110, 178);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(14, 19);
            this.lblDateEmbauche.TabIndex = 25;
            this.lblDateEmbauche.Text = ".";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDateNaissance.ForeColor = System.Drawing.Color.Black;
            this.lblDateNaissance.Location = new System.Drawing.Point(94, 138);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(14, 19);
            this.lblDateNaissance.TabIndex = 24;
            this.lblDateNaissance.Text = ".";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(94, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(14, 19);
            this.lblNom.TabIndex = 23;
            this.lblNom.Text = ".";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPrenom.ForeColor = System.Drawing.Color.Black;
            this.lblPrenom.Location = new System.Drawing.Point(94, 66);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(14, 19);
            this.lblPrenom.TabIndex = 22;
            this.lblPrenom.Text = ".";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSexe.ForeColor = System.Drawing.Color.Black;
            this.lblSexe.Location = new System.Drawing.Point(94, 102);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(14, 19);
            this.lblSexe.TabIndex = 21;
            this.lblSexe.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Embauché le : ";
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbVolontaire.ForeColor = System.Drawing.Color.Black;
            this.rdbVolontaire.Location = new System.Drawing.Point(97, 251);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(102, 23);
            this.rdbVolontaire.TabIndex = 14;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Enabled = false;
            this.rdbPro.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbPro.ForeColor = System.Drawing.Color.Black;
            this.rdbPro.Location = new System.Drawing.Point(97, 218);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(120, 23);
            this.rdbPro.TabIndex = 13;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Né le : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sexe :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnInfo.Location = new System.Drawing.Point(285, 287);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(195, 32);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Plus d\'informations";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(215, 71);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Nouveau Pompier";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // UCGestionPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.flpPompier);
            this.Controls.Add(this.flpCaserne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCGestionPerso";
            this.Size = new System.Drawing.Size(990, 630);
            this.Load += new System.EventHandler(this.UCGestionPerso_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.grpCaserne.ResumeLayout(false);
            this.grpCaserne.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.grpIdentite.ResumeLayout(false);
            this.grpIdentite.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
