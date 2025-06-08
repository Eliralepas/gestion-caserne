namespace SAE_Aparcio_Claudel_Meral
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
            panelVolet = new Panel();
            panelNavigation = new Panel();
            btnQuitter = new Button();
            btn5 = new NavigationBarUserControl.UCButton();
            btn1 = new NavigationBarUserControl.UCButton();
            btn4 = new NavigationBarUserControl.UCButton();
            btn2 = new NavigationBarUserControl.UCButton();
            btn3 = new NavigationBarUserControl.UCButton();
            picBoxCaserne = new PictureBox();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCaserne).BeginInit();
            SuspendLayout();
            // 
            // panelVolet
            // 
            panelVolet.AutoScroll = true;
            panelVolet.Location = new Point(302, 12);
            panelVolet.Name = "panelVolet";
            panelVolet.Size = new Size(1047, 647);
            panelVolet.TabIndex = 2;
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.DarkRed;
            panelNavigation.Controls.Add(btnQuitter);
            panelNavigation.Controls.Add(btn5);
            panelNavigation.Controls.Add(btn1);
            panelNavigation.Controls.Add(btn4);
            panelNavigation.Controls.Add(btn2);
            panelNavigation.Controls.Add(btn3);
            panelNavigation.Location = new Point(13, 13);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(283, 628);
            panelNavigation.TabIndex = 3;
            // 
            // btnQuitter
            // 
            btnQuitter.AutoSize = true;
            btnQuitter.Font = new Font("Arial", 18.2F, FontStyle.Bold);
            btnQuitter.ForeColor = Color.DarkRed;
            btnQuitter.Location = new Point(77, 561);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(124, 46);
            btnQuitter.TabIndex = 5;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btn5
            // 
            btn5.Buttonimage = Properties.Resources.stat;
            btn5.buttonText = "Statistiques";
            btn5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(14, 387);
            btn5.Margin = new Padding(4, 5, 4, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(225, 77);
            btn5.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Buttonimage = Properties.Resources.tableau_de_bord1;
            btn1.buttonText = "Tableau de bord";
            btn1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(10, 26);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(229, 83);
            btn1.TabIndex = 0;
            // 
            // btn4
            // 
            btn4.Buttonimage = Properties.Resources.perso;
            btn4.buttonText = "Gestion du personnel";
            btn4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(14, 294);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(225, 83);
            btn4.TabIndex = 2;
            // 
            // btn2
            // 
            btn2.Buttonimage = Properties.Resources.alarme;
            btn2.buttonText = "Nouvelle mission";
            btn2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(10, 119);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(229, 79);
            btn2.TabIndex = 4;
            // 
            // btn3
            // 
            btn3.Buttonimage = Properties.Resources.pompiers;
            btn3.buttonText = "Gestion des engins";
            btn3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(10, 208);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(229, 76);
            btn3.TabIndex = 1;
            // 
            // picBoxCaserne
            // 
            picBoxCaserne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxCaserne.BackgroundImageLayout = ImageLayout.Center;
            picBoxCaserne.Image = Properties.Resources.back;
            picBoxCaserne.Location = new Point(-3, -1);
            picBoxCaserne.Name = "picBoxCaserne";
            picBoxCaserne.Size = new Size(1352, 660);
            picBoxCaserne.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCaserne.TabIndex = 0;
            picBoxCaserne.TabStop = false;
            // 
            // frmCaserne
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1371, 671);
            Controls.Add(panelNavigation);
            Controls.Add(panelVolet);
            Controls.Add(picBoxCaserne);
            Font = new Font("Arial", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmCaserne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quoi ?!  Les soldats du feur";
            Load += frmCaserne_Load;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCaserne).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnQuitter;
    }
}

