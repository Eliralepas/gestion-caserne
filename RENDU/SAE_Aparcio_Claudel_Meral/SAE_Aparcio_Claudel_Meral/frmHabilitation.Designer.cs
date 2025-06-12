namespace SAE_Aparcio_Claudel_Meral
{
    partial class frmHabilitation
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
            if(disposing && (components != null))
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
            chklist = new CheckedListBox();
            btnValider = new Button();
            SuspendLayout();
            // 
            // chklist
            // 
            chklist.CheckOnClick = true;
            chklist.FormattingEnabled = true;
            chklist.Location = new Point(20, 17);
            chklist.Name = "chklist";
            chklist.Size = new Size(342, 292);
            chklist.TabIndex = 0;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(131, 316);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(115, 36);
            btnValider.TabIndex = 1;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // frmHabilitation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 364);
            Controls.Add(btnValider);
            Controls.Add(chklist);
            Name = "frmHabilitation";
            Text = "Gestion des habilitation";
            Load += frmHabilitation_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox chklist;
        private Button btnValider;
    }
}