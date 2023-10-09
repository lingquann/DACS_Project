namespace QLyPhongTro.FormCon
{
    partial class FormWellcome
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
            label1 = new Label();
            ptbLogo = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(542, 163);
            label1.Name = "label1";
            label1.Size = new Size(197, 38);
            label1.TabIndex = 0;
            label1.Text = "Wellcome";
            label1.Click += label1_Click;
            // 
            // ptbLogo
            // 
            ptbLogo.Anchor = AnchorStyles.Top;
            ptbLogo.Image = Properties.Resources.logo1;
            ptbLogo.Location = new Point(134, 87);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(300, 300);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 1;
            ptbLogo.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(459, 231);
            label2.Name = "label2";
            label2.Size = new Size(366, 29);
            label2.TabIndex = 2;
            label2.Text = "Phan mem quan ly phong tro";
            // 
            // FormWellcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 226, 255);
            ClientSize = new Size(973, 520);
            Controls.Add(label2);
            Controls.Add(ptbLogo);
            Controls.Add(label1);
            Name = "FormWellcome";
            Text = "FormWellcome";
            Load += FormWellcome_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox ptbLogo;
        private Label label2;
    }
}