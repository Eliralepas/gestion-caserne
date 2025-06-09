namespace UC_PanneEngins
{
    partial class frmReparations
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
            this.txtReparations = new System.Windows.Forms.RichTextBox();
            this.lblReparations = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReparations
            // 
            this.txtReparations.Font = new System.Drawing.Font("Arial", 12F);
            this.txtReparations.Location = new System.Drawing.Point(62, 56);
            this.txtReparations.Name = "txtReparations";
            this.txtReparations.Size = new System.Drawing.Size(404, 180);
            this.txtReparations.TabIndex = 0;
            this.txtReparations.Text = "";
            // 
            // lblReparations
            // 
            this.lblReparations.AutoSize = true;
            this.lblReparations.Font = new System.Drawing.Font("Arial", 12F);
            this.lblReparations.ForeColor = System.Drawing.Color.White;
            this.lblReparations.Location = new System.Drawing.Point(83, 19);
            this.lblReparations.Name = "lblReparations";
            this.lblReparations.Size = new System.Drawing.Size(366, 23);
            this.lblReparations.TabIndex = 1;
            this.lblReparations.Text = "Veuillez saisir les réparations éventuelles";
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.Font = new System.Drawing.Font("Arial", 14F);
            this.btnValider.ForeColor = System.Drawing.Color.DarkRed;
            this.btnValider.Location = new System.Drawing.Point(130, 245);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 37);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AutoSize = true;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 14F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAnnuler.Location = new System.Drawing.Point(293, 245);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(106, 37);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmReparations
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(532, 294);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblReparations);
            this.Controls.Add(this.txtReparations);
            this.Name = "frmReparations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparations eventuelles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtReparations;
        private System.Windows.Forms.Label lblReparations;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}