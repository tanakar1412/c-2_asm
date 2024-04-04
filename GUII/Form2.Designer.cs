namespace GUII
{
    partial class Launch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launch));
            btnTraCuu = new Button();
            btnBanHang = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTraCuu
            // 
            btnTraCuu.Location = new Point(1293, 231);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(229, 85);
            btnTraCuu.TabIndex = 0;
            btnTraCuu.Text = "Tra Cuu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.Location = new Point(1293, 387);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(229, 85);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Ban Hang";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1266, 630);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Launch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 711);
            Controls.Add(pictureBox1);
            Controls.Add(btnBanHang);
            Controls.Add(btnTraCuu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Launch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASM SIEU CAP VJP RPO";
            Load += Launch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTraCuu;
        private Button btnBanHang;
        private PictureBox pictureBox1;
    }
}