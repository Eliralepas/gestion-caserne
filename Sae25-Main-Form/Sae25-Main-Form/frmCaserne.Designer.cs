namespace Sae25_Main_Form
{
    partial class frmCaserne
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaserne));
            this.picBoxCaserne = new System.Windows.Forms.PictureBox();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.btn2 = new NavigationBarUserControl.UCButton();
            this.btn5 = new NavigationBarUserControl.UCButton();
            this.btn4 = new NavigationBarUserControl.UCButton();
            this.btn3 = new NavigationBarUserControl.UCButton();
            this.btn1 = new NavigationBarUserControl.UCButton();
            this.grpVolet = new System.Windows.Forms.GroupBox();
            this.Tablodebord = new UC_TableauDeBord.UC_TableauDeBord();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).BeginInit();
            this.grpNavigation.SuspendLayout();
            this.grpVolet.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxCaserne
            // 
            this.picBoxCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCaserne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxCaserne.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCaserne.Image")));
            this.picBoxCaserne.Location = new System.Drawing.Point(0, 0);
            this.picBoxCaserne.Name = "picBoxCaserne";
            this.picBoxCaserne.Size = new System.Drawing.Size(1185, 700);
            this.picBoxCaserne.TabIndex = 0;
            this.picBoxCaserne.TabStop = false;
            // 
            // grpNavigation
            // 
            this.grpNavigation.BackColor = System.Drawing.Color.DarkRed;
            this.grpNavigation.Controls.Add(this.btn2);
            this.grpNavigation.Controls.Add(this.btn5);
            this.grpNavigation.Controls.Add(this.btn4);
            this.grpNavigation.Controls.Add(this.btn3);
            this.grpNavigation.Controls.Add(this.btn1);
            this.grpNavigation.Location = new System.Drawing.Point(12, 12);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(296, 629);
            this.grpNavigation.TabIndex = 1;
            this.grpNavigation.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(7, 121);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(282, 112);
            this.btn2.TabIndex = 4;
            this.btn2.UcControled = null;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(7, 426);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(282, 112);
            this.btn5.TabIndex = 3;
            this.btn5.UcControled = null;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(7, 320);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(282, 112);
            this.btn4.TabIndex = 2;
            this.btn4.UcControled = null;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(7, 223);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(282, 112);
            this.btn3.TabIndex = 1;
            this.btn3.UcControled = null;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(7, 17);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(282, 112);
            this.btn1.TabIndex = 0;
            this.btn1.UcControled = null;
            // 
            // grpVolet
            // 
            this.grpVolet.Controls.Add(this.Tablodebord);
            this.grpVolet.Location = new System.Drawing.Point(324, 12);
            this.grpVolet.Name = "grpVolet";
            this.grpVolet.Size = new System.Drawing.Size(846, 629);
            this.grpVolet.TabIndex = 2;
            this.grpVolet.TabStop = false;
            // 
            // Tablodebord
            // 
            this.Tablodebord.Font = new System.Drawing.Font("Arial", 14F);
            this.Tablodebord.Location = new System.Drawing.Point(8, 17);
            this.Tablodebord.Margin = new System.Windows.Forms.Padding(5);
            this.Tablodebord.Name = "Tablodebord";
            this.Tablodebord.Size = new System.Drawing.Size(414, 415);
            this.Tablodebord.TabIndex = 0;
            this.Tablodebord.Load += new System.EventHandler(this.Tablodebord_Load);
            // 
            // frmCaserne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.grpVolet);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.picBoxCaserne);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaserne";
            this.Text = "Pinpon 🚒";
            this.Load += new System.EventHandler(this.frmCaserne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).EndInit();
            this.grpNavigation.ResumeLayout(false);
            this.grpVolet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCaserne;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.GroupBox grpVolet;
        private UC_TableauDeBord.UC_TableauDeBord Tablodebord;
        private NavigationBarUserControl.UCButton btn2;
        private NavigationBarUserControl.UCButton btn5;
        private NavigationBarUserControl.UCButton btn4;
        private NavigationBarUserControl.UCButton btn3;
        private NavigationBarUserControl.UCButton btn1;
    }
}

