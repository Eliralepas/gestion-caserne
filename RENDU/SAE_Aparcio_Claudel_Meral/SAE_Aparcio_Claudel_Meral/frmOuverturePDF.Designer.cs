namespace UC_Mission
{
    partial class frmOuverturePDF
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
            this.lblDemande = new System.Windows.Forms.Label();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDemande
            // 
            this.lblDemande.BackColor = System.Drawing.Color.Transparent;
            this.lblDemande.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemande.ForeColor = System.Drawing.Color.White;
            this.lblDemande.Location = new System.Drawing.Point(35, 26);
            this.lblDemande.Name = "lblDemande";
            this.lblDemande.Size = new System.Drawing.Size(218, 58);
            this.lblDemande.TabIndex = 0;
            this.lblDemande.Text = "Souhaitez-vous ouvrir le PDF généré ?";
            // 
            // btnOui
            // 
            this.btnOui.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOui.ForeColor = System.Drawing.Color.DarkRed;
            this.btnOui.Location = new System.Drawing.Point(39, 87);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(90, 45);
            this.btnOui.TabIndex = 1;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNon.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNon.Location = new System.Drawing.Point(163, 87);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(90, 45);
            this.btnNon.TabIndex = 2;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // frmOuverturePDF
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(294, 144);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.lblDemande);
            this.Name = "frmOuverturePDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouverture du PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDemande;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
    }
}