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
            this.grpVolet = new System.Windows.Forms.GroupBox();
            this.button5 = new NavigationBarUserControl.button();
            this.button4 = new NavigationBarUserControl.button();
            this.button3 = new NavigationBarUserControl.button();
            this.button2 = new NavigationBarUserControl.button();
            this.button1 = new NavigationBarUserControl.button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).BeginInit();
            this.grpNavigation.SuspendLayout();
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
            this.grpNavigation.Controls.Add(this.button5);
            this.grpNavigation.Controls.Add(this.button4);
            this.grpNavigation.Controls.Add(this.button3);
            this.grpNavigation.Controls.Add(this.button2);
            this.grpNavigation.Controls.Add(this.button1);
            this.grpNavigation.Location = new System.Drawing.Point(12, 12);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(296, 629);
            this.grpNavigation.TabIndex = 1;
            this.grpNavigation.TabStop = false;
            // 
            // grpVolet
            // 
            this.grpVolet.Location = new System.Drawing.Point(324, 12);
            this.grpVolet.Name = "grpVolet";
            this.grpVolet.Size = new System.Drawing.Size(846, 629);
            this.grpVolet.TabIndex = 2;
            this.grpVolet.TabStop = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(5, 418);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 120);
            this.button5.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(7, 319);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 120);
            this.button4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(5, 216);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 120);
            this.button3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 120);
            this.button2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 120);
            this.button1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).EndInit();
            this.grpNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCaserne;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.GroupBox grpVolet;
        private NavigationBarUserControl.button button1;
        private NavigationBarUserControl.button button2;
        private NavigationBarUserControl.button button5;
        private NavigationBarUserControl.button button4;
        private NavigationBarUserControl.button button3;
    }
}

