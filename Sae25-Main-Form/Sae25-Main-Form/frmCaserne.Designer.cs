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
            this.btnNum5 = new NavigationBarUserControl.button();
            this.btnNum4 = new NavigationBarUserControl.button();
            this.btnNum3 = new NavigationBarUserControl.button();
            this.btnNum2 = new NavigationBarUserControl.button();
            this.btnNum1 = new NavigationBarUserControl.button();
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
            this.grpNavigation.Controls.Add(this.btnNum5);
            this.grpNavigation.Controls.Add(this.btnNum4);
            this.grpNavigation.Controls.Add(this.btnNum3);
            this.grpNavigation.Controls.Add(this.btnNum2);
            this.grpNavigation.Controls.Add(this.btnNum1);
            this.grpNavigation.Location = new System.Drawing.Point(12, 12);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Size = new System.Drawing.Size(296, 629);
            this.grpNavigation.TabIndex = 1;
            this.grpNavigation.TabStop = false;
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(5, 418);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(272, 120);
            this.btnNum5.TabIndex = 4;
            this.btnNum5.UcControled = null;
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(7, 319);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(272, 120);
            this.btnNum4.TabIndex = 3;
            this.btnNum4.UcControled = null;
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(5, 216);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(272, 120);
            this.btnNum3.TabIndex = 2;
            this.btnNum3.UcControled = null;
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(6, 116);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(271, 120);
            this.btnNum2.TabIndex = 1;
            this.btnNum2.UcControled = null;
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(6, 17);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(272, 120);
            this.btnNum1.TabIndex = 0;
            this.btnNum1.UcControled = null;
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
            this.Tablodebord.Location = new System.Drawing.Point(33, 35);
            this.Tablodebord.Margin = new System.Windows.Forms.Padding(5);
            this.Tablodebord.Name = "Tablodebord";
            this.Tablodebord.Size = new System.Drawing.Size(431, 415);
            this.Tablodebord.TabIndex = 0;
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
        private NavigationBarUserControl.button btnNum1;
        private NavigationBarUserControl.button btnNum2;
        private NavigationBarUserControl.button btnNum5;
        private NavigationBarUserControl.button btnNum4;
        private NavigationBarUserControl.button btnNum3;
        private UC_TableauDeBord.UC_TableauDeBord Tablodebord;
    }
}

