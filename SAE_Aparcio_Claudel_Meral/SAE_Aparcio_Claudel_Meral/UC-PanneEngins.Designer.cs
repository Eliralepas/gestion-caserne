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
            this.picBoxEngin = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTextType = new System.Windows.Forms.Label();
            this.lblTextNumero = new System.Windows.Forms.Label();
            this.ckbEnPanne = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxEngin
            // 
            this.picBoxEngin.Location = new System.Drawing.Point(4, 4);
            this.picBoxEngin.Name = "picBoxEngin";
            this.picBoxEngin.Size = new System.Drawing.Size(142, 142);
            this.picBoxEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEngin.TabIndex = 0;
            this.picBoxEngin.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(252, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 19);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(252, 69);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(42, 19);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Num";
            // 
            // lblTextType
            // 
            this.lblTextType.AutoSize = true;
            this.lblTextType.Location = new System.Drawing.Point(152, 29);
            this.lblTextType.Name = "lblTextType";
            this.lblTextType.Size = new System.Drawing.Size(94, 19);
            this.lblTextType.TabIndex = 3;
            this.lblTextType.Text = "Type engin:";
            // 
            // lblTextNumero
            // 
            this.lblTextNumero.AutoSize = true;
            this.lblTextNumero.Location = new System.Drawing.Point(152, 69);
            this.lblTextNumero.Name = "lblTextNumero";
            this.lblTextNumero.Size = new System.Drawing.Size(71, 19);
            this.lblTextNumero.TabIndex = 4;
            this.lblTextNumero.Text = "Numero:";
            // 
            // ckbEnPanne
            // 
            this.ckbEnPanne.AutoSize = true;
            this.ckbEnPanne.Font = new System.Drawing.Font("Arial", 10F);
            this.ckbEnPanne.Location = new System.Drawing.Point(374, 65);
            this.ckbEnPanne.Name = "ckbEnPanne";
            this.ckbEnPanne.Size = new System.Drawing.Size(101, 23);
            this.ckbEnPanne.TabIndex = 5;
            this.ckbEnPanne.Text = "En panne";
            this.ckbEnPanne.UseVisualStyleBackColor = true;
            this.ckbEnPanne.Click += new System.EventHandler(this.ckbEnPanne_Click);
            // 
            // UC_PanneEngins
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ckbEnPanne);
            this.Controls.Add(this.lblTextNumero);
            this.Controls.Add(this.lblTextType);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.picBoxEngin);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Name = "UC_PanneEngins";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
