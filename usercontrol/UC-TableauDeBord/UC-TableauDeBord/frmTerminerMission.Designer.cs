namespace UC_TableauDeBord
{
    partial class frmTerminerMission
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
            this.cboMissionId = new System.Windows.Forms.ComboBox();
            this.txtCompteRendu = new System.Windows.Forms.RichTextBox();
            this.lblCompteRendu = new System.Windows.Forms.Label();
            this.lblMissionId = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMissionId
            // 
            this.cboMissionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMissionId.FormattingEnabled = true;
            this.cboMissionId.Location = new System.Drawing.Point(372, 27);
            this.cboMissionId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMissionId.Name = "cboMissionId";
            this.cboMissionId.Size = new System.Drawing.Size(136, 27);
            this.cboMissionId.TabIndex = 0;
            // 
            // txtCompteRendu
            // 
            this.txtCompteRendu.Location = new System.Drawing.Point(14, 122);
            this.txtCompteRendu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompteRendu.Name = "txtCompteRendu";
            this.txtCompteRendu.Size = new System.Drawing.Size(528, 298);
            this.txtCompteRendu.TabIndex = 1;
            this.txtCompteRendu.Text = "";
            // 
            // lblCompteRendu
            // 
            this.lblCompteRendu.AutoSize = true;
            this.lblCompteRendu.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblCompteRendu.ForeColor = System.Drawing.Color.White;
            this.lblCompteRendu.Location = new System.Drawing.Point(185, 89);
            this.lblCompteRendu.Name = "lblCompteRendu";
            this.lblCompteRendu.Size = new System.Drawing.Size(184, 29);
            this.lblCompteRendu.TabIndex = 2;
            this.lblCompteRendu.Text = "Compte Rendu";
            // 
            // lblMissionId
            // 
            this.lblMissionId.AutoSize = true;
            this.lblMissionId.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Bold);
            this.lblMissionId.ForeColor = System.Drawing.Color.White;
            this.lblMissionId.Location = new System.Drawing.Point(89, 25);
            this.lblMissionId.Name = "lblMissionId";
            this.lblMissionId.Size = new System.Drawing.Size(277, 29);
            this.lblMissionId.TabIndex = 3;
            this.lblMissionId.Text = "Numéro de la mission :";
            // 
            // btnValider
            // 
            this.btnValider.AutoSize = true;
            this.btnValider.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.DarkRed;
            this.btnValider.Location = new System.Drawing.Point(153, 427);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(99, 37);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.AutoSize = true;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAnnuler.Location = new System.Drawing.Point(297, 427);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 37);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmTerminerMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(556, 474);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMissionId);
            this.Controls.Add(this.lblCompteRendu);
            this.Controls.Add(this.txtCompteRendu);
            this.Controls.Add(this.cboMissionId);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTerminerMission";
            this.Text = "Terminer mission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMissionId;
        private System.Windows.Forms.RichTextBox txtCompteRendu;
        private System.Windows.Forms.Label lblCompteRendu;
        private System.Windows.Forms.Label lblMissionId;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}