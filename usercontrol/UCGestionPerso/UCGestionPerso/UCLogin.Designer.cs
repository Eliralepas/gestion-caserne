namespace UCGestionPerso
{
    partial class UCLogin
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
            if(disposing && (components != null))
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblTitleUser = new System.Windows.Forms.Label();
            this.lblTitlePwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnShowPwd = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(211, 47);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(239, 26);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblTitleUser
            // 
            this.lblTitleUser.AutoSize = true;
            this.lblTitleUser.Location = new System.Drawing.Point(44, 50);
            this.lblTitleUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitleUser.Name = "lblTitleUser";
            this.lblTitleUser.Size = new System.Drawing.Size(151, 18);
            this.lblTitleUser.TabIndex = 1;
            this.lblTitleUser.Text = "Nom d\'utilisateur :";
            // 
            // lblTitlePwd
            // 
            this.lblTitlePwd.AutoSize = true;
            this.lblTitlePwd.Location = new System.Drawing.Point(44, 95);
            this.lblTitlePwd.Name = "lblTitlePwd";
            this.lblTitlePwd.Size = new System.Drawing.Size(127, 18);
            this.lblTitlePwd.TabIndex = 2;
            this.lblTitlePwd.Text = "Mot de Passe : ";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(211, 92);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(239, 26);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnShowPwd
            // 
            this.btnShowPwd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPwd.Location = new System.Drawing.Point(458, 81);
            this.btnShowPwd.Name = "btnShowPwd";
            this.btnShowPwd.Size = new System.Drawing.Size(51, 40);
            this.btnShowPwd.TabIndex = 4;
            this.btnShowPwd.Text = "👀";
            this.btnShowPwd.UseVisualStyleBackColor = true;
            this.btnShowPwd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(248, 125);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(152, 35);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnShowPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblTitlePwd);
            this.Controls.Add(this.lblTitleUser);
            this.Controls.Add(this.txtUser);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(560, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.Label lblTitlePwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Button btnValider;
    }
}
