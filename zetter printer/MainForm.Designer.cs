namespace zetter_printer
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            targetImage = new PictureBox();
            targetImageLabel = new Label();
            openImageDialog = new OpenFileDialog();
            toolPanel = new Panel();
            canvasNumY = new TextBox();
            canvasNumX = new TextBox();
            canvasCountY = new TextBox();
            canvasCountX = new TextBox();
            printButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            resultImage = new PictureBox();
            label5 = new Label();
            previewButton = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)targetImage).BeginInit();
            toolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultImage).BeginInit();
            SuspendLayout();
            // 
            // targetImage
            // 
            targetImage.BackColor = Color.FromArgb(32, 32, 32);
            targetImage.Location = new Point(12, 12);
            targetImage.Name = "targetImage";
            targetImage.Size = new Size(225, 225);
            targetImage.SizeMode = PictureBoxSizeMode.Zoom;
            targetImage.TabIndex = 0;
            targetImage.TabStop = false;
            targetImage.Click += targetImage_Click;
            // 
            // targetImageLabel
            // 
            targetImageLabel.AutoSize = true;
            targetImageLabel.ForeColor = Color.FromArgb(156, 126, 197);
            targetImageLabel.Location = new Point(12, 238);
            targetImageLabel.Name = "targetImageLabel";
            targetImageLabel.Size = new Size(225, 15);
            targetImageLabel.TabIndex = 1;
            targetImageLabel.Text = "Нажмите, чтобы выбрать изображение";
            // 
            // openImageDialog
            // 
            openImageDialog.FileName = "openFileDialog1";
            openImageDialog.Filter = "Картинки | *.png; *.jpg; *.jpeg";
            // 
            // toolPanel
            // 
            toolPanel.BackColor = Color.FromArgb(25, 25, 25);
            toolPanel.Controls.Add(canvasNumY);
            toolPanel.Controls.Add(canvasNumX);
            toolPanel.Controls.Add(canvasCountY);
            toolPanel.Controls.Add(canvasCountX);
            toolPanel.Controls.Add(printButton);
            toolPanel.Enabled = false;
            toolPanel.Location = new Point(243, 12);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(128, 223);
            toolPanel.TabIndex = 2;
            // 
            // canvasNumY
            // 
            canvasNumY.BackColor = Color.FromArgb(32, 32, 32);
            canvasNumY.BorderStyle = BorderStyle.None;
            canvasNumY.ForeColor = Color.FromArgb(156, 126, 197);
            canvasNumY.Location = new Point(15, 108);
            canvasNumY.MaxLength = 2;
            canvasNumY.Name = "canvasNumY";
            canvasNumY.Size = new Size(100, 16);
            canvasNumY.TabIndex = 8;
            canvasNumY.Text = "1";
            canvasNumY.TextChanged += canvasNumY_TextChanged;
            // 
            // canvasNumX
            // 
            canvasNumX.BackColor = Color.FromArgb(32, 32, 32);
            canvasNumX.BorderStyle = BorderStyle.None;
            canvasNumX.ForeColor = Color.FromArgb(156, 126, 197);
            canvasNumX.Location = new Point(14, 77);
            canvasNumX.MaxLength = 2;
            canvasNumX.Name = "canvasNumX";
            canvasNumX.Size = new Size(100, 16);
            canvasNumX.TabIndex = 7;
            canvasNumX.Text = "1";
            canvasNumX.TextChanged += canvasNumX_TextChanged;
            // 
            // canvasCountY
            // 
            canvasCountY.BackColor = Color.FromArgb(32, 32, 32);
            canvasCountY.BorderStyle = BorderStyle.None;
            canvasCountY.ForeColor = Color.FromArgb(156, 126, 197);
            canvasCountY.Location = new Point(14, 46);
            canvasCountY.MaxLength = 2;
            canvasCountY.Name = "canvasCountY";
            canvasCountY.Size = new Size(100, 16);
            canvasCountY.TabIndex = 6;
            canvasCountY.Text = "1";
            canvasCountY.TextChanged += canvasCountY_TextChanged;
            // 
            // canvasCountX
            // 
            canvasCountX.BackColor = Color.FromArgb(32, 32, 32);
            canvasCountX.BorderStyle = BorderStyle.None;
            canvasCountX.ForeColor = Color.FromArgb(156, 126, 197);
            canvasCountX.Location = new Point(14, 17);
            canvasCountX.MaxLength = 2;
            canvasCountX.Name = "canvasCountX";
            canvasCountX.Size = new Size(100, 16);
            canvasCountX.TabIndex = 5;
            canvasCountX.Text = "1";
            canvasCountX.TextChanged += canvasCountX_TextChanged;
            // 
            // printButton
            // 
            printButton.BackColor = Color.FromArgb(32, 32, 32);
            printButton.FlatAppearance.BorderSize = 0;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.ForeColor = Color.FromArgb(156, 126, 197);
            printButton.Location = new Point(14, 193);
            printButton.Name = "printButton";
            printButton.Size = new Size(101, 23);
            printButton.TabIndex = 4;
            printButton.TabStop = false;
            printButton.Text = "Начать печать";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(156, 126, 197);
            label4.Location = new Point(386, 120);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Номер холста Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(156, 126, 197);
            label3.Location = new Point(386, 89);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "Номер холста Х";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(156, 126, 197);
            label2.Location = new Point(386, 61);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Число холстов по Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(156, 126, 197);
            label1.Location = new Point(386, 32);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 2;
            label1.Text = "Число холстов по Х";
            // 
            // resultImage
            // 
            resultImage.BackColor = Color.FromArgb(32, 32, 32);
            resultImage.Location = new Point(517, 12);
            resultImage.Margin = new Padding(12, 12, 12, 12);
            resultImage.Name = "resultImage";
            resultImage.Size = new Size(225, 225);
            resultImage.SizeMode = PictureBoxSizeMode.Zoom;
            resultImage.TabIndex = 3;
            resultImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(156, 126, 197);
            label5.Location = new Point(517, 238);
            label5.Margin = new Padding(3, 3, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Итоговый холст";
            // 
            // previewButton
            // 
            previewButton.BackColor = Color.FromArgb(32, 32, 32);
            previewButton.Enabled = false;
            previewButton.FlatAppearance.BorderSize = 0;
            previewButton.FlatStyle = FlatStyle.Flat;
            previewButton.ForeColor = Color.FromArgb(156, 126, 197);
            previewButton.Location = new Point(387, 205);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(116, 23);
            previewButton.TabIndex = 9;
            previewButton.TabStop = false;
            previewButton.Text = "Предпросмотр";
            previewButton.UseVisualStyleBackColor = true;
            previewButton.Click += previewButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(12, 255);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(181, 19);
            checkBox1.TabIndex = 10;
            checkBox1.TabStop = false;
            checkBox1.Text = "Рисование на холстах 2 на 2";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(756, 325);
            Controls.Add(checkBox1);
            Controls.Add(previewButton);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(resultImage);
            Controls.Add(toolPanel);
            Controls.Add(targetImageLabel);
            Controls.Add(targetImage);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(156, 126, 197);
            Name = "mainForm";
            Text = "Zetter printer";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)targetImage).EndInit();
            toolPanel.ResumeLayout(false);
            toolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox targetImage;
        private Label targetImageLabel;
        private OpenFileDialog openImageDialog;
        private Panel toolPanel;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button printButton;
        private PictureBox resultImage;
        private Label label5;
        private TextBox canvasNumY;
        private TextBox canvasNumX;
        private TextBox canvasCountY;
        private TextBox canvasCountX;
        private Button previewButton;
        private CheckBox checkBox1;
    }
}
