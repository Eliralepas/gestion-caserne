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
            this.panelVolet = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btn5 = new NavigationBarUserControl.UCButton();
            this.btn1 = new NavigationBarUserControl.UCButton();
            this.btn4 = new NavigationBarUserControl.UCButton();
            this.btn2 = new NavigationBarUserControl.UCButton();
            this.btn3 = new NavigationBarUserControl.UCButton();
            this.picBoxCaserne = new System.Windows.Forms.PictureBox();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVolet
            // 
            this.panelVolet.AutoScroll = true;
            this.panelVolet.Location = new System.Drawing.Point(302, 12);
            this.panelVolet.Name = "panelVolet";
            this.panelVolet.Size = new System.Drawing.Size(1003, 647);
            this.panelVolet.TabIndex = 2;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.DarkRed;
            this.panelNavigation.Controls.Add(this.btn5);
            this.panelNavigation.Controls.Add(this.btn1);
            this.panelNavigation.Controls.Add(this.btn4);
            this.panelNavigation.Controls.Add(this.btn2);
            this.panelNavigation.Controls.Add(this.btn3);
            this.panelNavigation.Location = new System.Drawing.Point(13, 13);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(283, 628);
            this.panelNavigation.TabIndex = 3;
            // 
            // btn5
            // 
            this.btn5.Buttonimage = global::Sae25_Main_Form.Properties.Resources.stat;
            this.btn5.buttonText = "Statistiques";
            this.btn5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(14, 387);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(225, 77);
            this.btn5.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Buttonimage = global::Sae25_Main_Form.Properties.Resources.tableau_de_bord;
            this.btn1.buttonText = "Tableau de bord";
            this.btn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(10, 26);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(229, 83);
            this.btn1.TabIndex = 0;
            // 
            // btn4
            // 
            this.btn4.Buttonimage = global::Sae25_Main_Form.Properties.Resources.perso;
            this.btn4.buttonText = "Gestion du personnel";
            this.btn4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(14, 294);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(225, 83);
            this.btn4.TabIndex = 2;
            // 
            // btn2
            // 
            this.btn2.Buttonimage = global::Sae25_Main_Form.Properties.Resources.alarme;
            this.btn2.buttonText = "Nouvelle mission";
            this.btn2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(10, 119);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(229, 79);
            this.btn2.TabIndex = 4;
            // 
            // btn3
            // 
            this.btn3.Buttonimage = global::Sae25_Main_Form.Properties.Resources.pompiers;
            this.btn3.buttonText = "Gestion des engins";
            this.btn3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(10, 208);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(229, 76);
            this.btn3.TabIndex = 1;
            // 
            // picBoxCaserne
            // 
            this.picBoxCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCaserne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxCaserne.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBoxCaserne.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCaserne.Image")));
            this.picBoxCaserne.Location = new System.Drawing.Point(-3, -1);
            this.picBoxCaserne.Name = "picBoxCaserne";
            this.picBoxCaserne.Size = new System.Drawing.Size(1337, 678);
            this.picBoxCaserne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCaserne.TabIndex = 0;
            this.picBoxCaserne.TabStop = false;
            // 
            // frmCaserne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1327, 671);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelVolet);
            this.Controls.Add(this.picBoxCaserne);
            this.Font = new System.Drawing.Font("Arial", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCaserne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quoi ?!  Les soldats du feur";
            this.Load += new System.EventHandler(this.frmCaserne_Load);
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaserne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCaserne;
        private NavigationBarUserControl.UCButton btn2;
        private NavigationBarUserControl.UCButton btn5;
        private NavigationBarUserControl.UCButton btn4;
        private NavigationBarUserControl.UCButton btn3;
        private NavigationBarUserControl.UCButton btn1;
        private System.Windows.Forms.Panel panelVolet;
        private System.Windows.Forms.Panel panelNavigation;
    }
}

