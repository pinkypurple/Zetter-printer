namespace zetter_printer
{
    partial class ImgPreview
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
            img = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // img
            // 
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.Dock = DockStyle.Fill;
            img.Location = new Point(0, 0);
            img.Name = "img";
            img.Size = new Size(800, 450);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.TabIndex = 0;
            img.TabStop = false;
            // 
            // ImgPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(800, 450);
            Controls.Add(img);
            Name = "ImgPreview";
            Text = "Превью";
            Load += ImgPreview_Load;
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img;
    }
}