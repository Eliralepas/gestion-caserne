namespace UC_GestionPerso
{
    partial class UCRichButton
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
            if(disposing && (components != null))
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
            pictureBox1 = new PictureBox();
            lblInfo1 = new Label();
            lblInfo2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += RichButton_MouseClick;
            pictureBox1.MouseEnter += UCRichButton_MouseEnter;
            // 
            // lblInfo1
            // 
            lblInfo1.AutoSize = true;
            lblInfo1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo1.Location = new Point(77, 14);
            lblInfo1.Margin = new Padding(4, 0, 4, 0);
            lblInfo1.Name = "lblInfo1";
            lblInfo1.Size = new Size(99, 16);
            lblInfo1.TabIndex = 1;
            lblInfo1.Text = "Information 1";
            lblInfo1.MouseClick += RichButton_MouseClick;
            lblInfo1.MouseEnter += UCRichButton_MouseEnter;
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Font = new Font("Arial", 10F);
            lblInfo2.Location = new Point(77, 41);
            lblInfo2.Margin = new Padding(4, 0, 4, 0);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(89, 16);
            lblInfo2.TabIndex = 2;
            lblInfo2.Text = "Information 2";
            lblInfo2.MouseClick += RichButton_MouseClick;
            lblInfo2.MouseEnter += UCRichButton_MouseEnter;
            // 
            // UCRichButton
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblInfo2);
            Controls.Add(lblInfo1);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCRichButton";
            Size = new Size(200, 75);
            Load += UCRichButton_Load;
            MouseClick += RichButton_MouseClick;
            MouseEnter += UCRichButton_MouseEnter;
            MouseLeave += UCRichButton_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
    }
}
