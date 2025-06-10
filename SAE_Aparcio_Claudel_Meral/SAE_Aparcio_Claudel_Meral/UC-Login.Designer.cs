namespace UC_GestionPerso
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
            txtUser = new TextBox();
            lblTitleUser = new Label();
            lblTitlePwd = new Label();
            txtPwd = new TextBox();
            btnShowPwd = new Button();
            btnValider = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(211, 47);
            txtUser.Margin = new Padding(5, 4, 5, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(239, 26);
            txtUser.TabIndex = 0;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // lblTitleUser
            // 
            lblTitleUser.AutoSize = true;
            lblTitleUser.Location = new Point(15, 50);
            lblTitleUser.Margin = new Padding(5, 0, 5, 0);
            lblTitleUser.Name = "lblTitleUser";
            lblTitleUser.Size = new Size(151, 18);
            lblTitleUser.TabIndex = 1;
            lblTitleUser.Text = "Nom d'utilisateur :";
            // 
            // lblTitlePwd
            // 
            lblTitlePwd.AutoSize = true;
            lblTitlePwd.Location = new Point(15, 95);
            lblTitlePwd.Name = "lblTitlePwd";
            lblTitlePwd.Size = new Size(127, 18);
            lblTitlePwd.TabIndex = 2;
            lblTitlePwd.Text = "Mot de Passe : ";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(211, 92);
            txtPwd.Margin = new Padding(5, 4, 5, 4);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(239, 26);
            txtPwd.TabIndex = 3;
            txtPwd.UseSystemPasswordChar = true;
            txtPwd.KeyPress += txtUser_KeyPress;
            // 
            // btnShowPwd
            // 
            btnShowPwd.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPwd.Location = new Point(458, 81);
            btnShowPwd.Name = "btnShowPwd";
            btnShowPwd.Size = new Size(51, 40);
            btnShowPwd.TabIndex = 4;
            btnShowPwd.Text = "👀";
            btnShowPwd.UseVisualStyleBackColor = true;
            btnShowPwd.Click += btnTogglePassword_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(211, 125);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(152, 35);
            btnValider.TabIndex = 5;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(369, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 35);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UCLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(btnCancel);
            Controls.Add(btnValider);
            Controls.Add(btnShowPwd);
            Controls.Add(txtPwd);
            Controls.Add(lblTitlePwd);
            Controls.Add(lblTitleUser);
            Controls.Add(txtUser);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UCLogin";
            Size = new Size(560, 177);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblTitleUser;
        private System.Windows.Forms.Label lblTitlePwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnShowPwd;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnCancel;
    }
}
