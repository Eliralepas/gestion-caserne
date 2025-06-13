namespace UC_PanneEngins
{
    partial class PanneEngins
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
            picBoxEngin = new PictureBox();
            lblType = new Label();
            lblNumero = new Label();
            lblTextType = new Label();
            lblTextNumero = new Label();
            ckbEnPanne = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picBoxEngin).BeginInit();
            SuspendLayout();
            // 
            // picBoxEngin
            // 
            picBoxEngin.Location = new Point(4, 4);
            picBoxEngin.Name = "picBoxEngin";
            picBoxEngin.Size = new Size(142, 142);
            picBoxEngin.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxEngin.TabIndex = 0;
            picBoxEngin.TabStop = false;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(252, 29);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 16);
            lblType.TabIndex = 1;
            lblType.Text = "Type";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(252, 69);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(35, 16);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Num";
            // 
            // lblTextType
            // 
            lblTextType.AutoSize = true;
            lblTextType.Location = new Point(152, 29);
            lblTextType.Name = "lblTextType";
            lblTextType.Size = new Size(81, 16);
            lblTextType.TabIndex = 3;
            lblTextType.Text = "Type engin:";
            // 
            // lblTextNumero
            // 
            lblTextNumero.AutoSize = true;
            lblTextNumero.Location = new Point(152, 69);
            lblTextNumero.Name = "lblTextNumero";
            lblTextNumero.Size = new Size(60, 16);
            lblTextNumero.TabIndex = 4;
            lblTextNumero.Text = "Numero:";
            // 
            // ckbEnPanne
            // 
            ckbEnPanne.AutoSize = true;
            ckbEnPanne.Font = new Font("Arial", 10F);
            ckbEnPanne.Location = new Point(374, 65);
            ckbEnPanne.Name = "ckbEnPanne";
            ckbEnPanne.Size = new Size(87, 20);
            ckbEnPanne.TabIndex = 5;
            ckbEnPanne.Text = "En panne";
            ckbEnPanne.UseVisualStyleBackColor = true;
            ckbEnPanne.Click += ckbEnPanne_Click;
            // 
            // PanneEngins
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(ckbEnPanne);
            Controls.Add(lblTextNumero);
            Controls.Add(lblTextType);
            Controls.Add(lblNumero);
            Controls.Add(lblType);
            Controls.Add(picBoxEngin);
            Font = new Font("Arial", 10F);
            Name = "PanneEngins";
            Size = new Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)picBoxEngin).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxEngin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTextType;
        private System.Windows.Forms.Label lblTextNumero;
        private System.Windows.Forms.CheckBox ckbEnPanne;
    }
}
