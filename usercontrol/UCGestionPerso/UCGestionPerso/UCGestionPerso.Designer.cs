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
            this.grpIdentite = new System.Windows.Forms.GroupBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grpCaserne = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbPro = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtBip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbHab = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbAffec = new System.Windows.Forms.RichTextBox();
            this.txtGradeCode = new System.Windows.Forms.TextBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.chbConge = new System.Windows.Forms.CheckBox();
            this.pnlInfo.SuspendLayout();
            this.grpIdentite.SuspendLayout();
            this.grpCaserne.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlInfo.Controls.Add(this.button1);
            this.pnlInfo.Controls.Add(this.grpContact);
            this.pnlInfo.Controls.Add(this.grpIdentite);
            this.pnlInfo.Controls.Add(this.btnInfo);
            this.pnlInfo.Location = new System.Drawing.Point(475, 5);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(510, 620);
            this.pnlInfo.TabIndex = 2;
            // 
            // grpIdentite
            // 
            this.grpIdentite.Controls.Add(this.textBox1);
            this.grpIdentite.Controls.Add(this.txtDateNaissance);
            this.grpIdentite.Controls.Add(this.txtPrenom);
            this.grpIdentite.Controls.Add(this.txtNom);
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
            // btnChanger
            // 
            this.btnChanger.Enabled = false;
            this.btnChanger.Font = new System.Drawing.Font("Arial", 10F);
            this.btnChanger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChanger.Location = new System.Drawing.Point(71, 245);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(138, 32);
            this.btnChanger.TabIndex = 0;
            this.btnChanger.Text = "Sauvegarder";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Enabled = false;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnInfo.Location = new System.Drawing.Point(292, 325);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(195, 32);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Plus d\'informations";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(215, 71);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Nouveau Pompier";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sexe :  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Né(e) le : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status :";
            // 
            // rdbPro
            // 
            this.rdbPro.AutoSize = true;
            this.rdbPro.Enabled = false;
            this.rdbPro.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbPro.ForeColor = System.Drawing.Color.Black;
            this.rdbPro.Location = new System.Drawing.Point(98, 217);
            this.rdbPro.Name = "rdbPro";
            this.rdbPro.Size = new System.Drawing.Size(143, 27);
            this.rdbPro.TabIndex = 13;
            this.rdbPro.TabStop = true;
            this.rdbPro.Text = "Professionel";
            this.rdbPro.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbVolontaire.ForeColor = System.Drawing.Color.Black;
            this.rdbVolontaire.Location = new System.Drawing.Point(98, 250);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(122, 27);
            this.rdbVolontaire.TabIndex = 14;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtBip);
            this.grpContact.Controls.Add(this.txtTel);
            this.grpContact.Controls.Add(this.pictureBox1);
            this.grpContact.Controls.Add(this.label6);
            this.grpContact.Controls.Add(this.btnChanger);
            this.grpContact.Controls.Add(this.label5);
            this.grpContact.Font = new System.Drawing.Font("Arial", 13F);
            this.grpContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpContact.Location = new System.Drawing.Point(278, 31);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(215, 288);
            this.grpContact.TabIndex = 15;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            this.grpContact.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Téléphone : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bip :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 79);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNom.Location = new System.Drawing.Point(98, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(132, 28);
            this.txtNom.TabIndex = 15;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPrenom.Location = new System.Drawing.Point(98, 88);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(132, 28);
            this.txtPrenom.TabIndex = 16;
            // 
            // txtDateNaissance
            // 
            this.txtDateNaissance.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDateNaissance.Location = new System.Drawing.Point(98, 172);
            this.txtDateNaissance.Name = "txtDateNaissance";
            this.txtDateNaissance.ReadOnly = true;
            this.txtDateNaissance.Size = new System.Drawing.Size(132, 28);
            this.txtDateNaissance.TabIndex = 17;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 9F);
            this.txtTel.Location = new System.Drawing.Point(10, 144);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(132, 28);
            this.txtTel.TabIndex = 18;
            // 
            // txtBip
            // 
            this.txtBip.Enabled = false;
            this.txtBip.Font = new System.Drawing.Font("Arial", 9F);
            this.txtBip.Location = new System.Drawing.Point(10, 206);
            this.txtBip.Name = "txtBip";
            this.txtBip.Size = new System.Drawing.Size(132, 28);
            this.txtBip.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grade :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Caserne : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Habilitations :";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.textBox1.Location = new System.Drawing.Point(98, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 28);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(349, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Mettre à jour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Affectations passés :";
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
            // txtGradeCode
            // 
            this.txtGradeCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txtGradeCode.Location = new System.Drawing.Point(98, 37);
            this.txtGradeCode.Name = "txtGradeCode";
            this.txtGradeCode.ReadOnly = true;
            this.txtGradeCode.Size = new System.Drawing.Size(91, 28);
            this.txtGradeCode.TabIndex = 19;
            // 
            // cboGrade
            // 
            this.cboGrade.Font = new System.Drawing.Font("Arial", 9F);
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(211, 36);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(255, 29);
            this.cboGrade.TabIndex = 24;
            this.cboGrade.Visible = false;
            // 
            // cboCaserne
            // 
            this.cboCaserne.Enabled = false;
            this.cboCaserne.Font = new System.Drawing.Font("Arial", 9F);
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(211, 69);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(255, 29);
            this.cboCaserne.TabIndex = 25;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMatricule.ForeColor = System.Drawing.Color.Black;
            this.lblMatricule.Location = new System.Drawing.Point(174, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(134, 32);
            this.lblMatricule.TabIndex = 19;
            this.lblMatricule.Text = "Matricule ";
            this.lblMatricule.Visible = false;
            // 
            // chbConge
            // 
            this.chbConge.AutoSize = true;
            this.chbConge.Font = new System.Drawing.Font("Arial", 10F);
            this.chbConge.Location = new System.Drawing.Point(10, 226);
            this.chbConge.Name = "chbConge";
            this.chbConge.Size = new System.Drawing.Size(116, 27);
            this.chbConge.TabIndex = 26;
            this.chbConge.Text = "en congé";
            this.chbConge.UseVisualStyleBackColor = true;
            // 
            // UCGestionPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
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
            this.grpIdentite.ResumeLayout(false);
            this.grpIdentite.PerformLayout();
            this.grpCaserne.ResumeLayout(false);
            this.grpCaserne.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCaserne;
        private System.Windows.Forms.FlowLayoutPanel flpPompier;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpCaserne;
        private System.Windows.Forms.GroupBox grpIdentite;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbPro;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBip;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.RichTextBox rtbHab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbAffec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.TextBox txtGradeCode;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.CheckBox chbConge;
    }
}
