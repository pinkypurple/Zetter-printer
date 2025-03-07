namespace zetter_printer
{
    partial class zoneSelector
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
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            paintSpeed = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(32, 32, 32);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(156, 126, 197);
            button4.Location = new Point(719, 472);
            button4.Name = "button4";
            button4.Size = new Size(144, 23);
            button4.TabIndex = 3;
            button4.Text = "Подтвердить лэйаут";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 32, 32);
            button5.FlatAppearance.BorderColor = Color.FromArgb(156, 126, 197);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(156, 126, 197);
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(60, 31);
            button5.TabIndex = 4;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(32, 32, 32);
            button1.FlatAppearance.BorderColor = Color.FromArgb(156, 126, 197);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(156, 126, 197);
            button1.Location = new Point(12, 469);
            button1.Name = "button1";
            button1.Size = new Size(176, 23);
            button1.TabIndex = 6;
            button1.Text = "Задать точку HEX";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(32, 32, 32);
            button2.FlatAppearance.BorderColor = Color.FromArgb(156, 126, 197);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(156, 126, 197);
            button2.Location = new Point(12, 440);
            button2.Name = "button2";
            button2.Size = new Size(176, 23);
            button2.TabIndex = 7;
            button2.Text = "Задать правый нижний угол";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(32, 32, 32);
            button3.FlatAppearance.BorderColor = Color.FromArgb(156, 126, 197);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(156, 126, 197);
            button3.Location = new Point(12, 411);
            button3.Name = "button3";
            button3.Size = new Size(176, 23);
            button3.TabIndex = 8;
            button3.Text = "Задать левый верхний угол";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // paintSpeed
            // 
            paintSpeed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            paintSpeed.BackColor = Color.FromArgb(50, 50, 50);
            paintSpeed.BorderStyle = BorderStyle.None;
            paintSpeed.ForeColor = Color.FromArgb(156, 126, 197);
            paintSpeed.Location = new Point(12, 343);
            paintSpeed.MaxLength = 3;
            paintSpeed.Name = "paintSpeed";
            paintSpeed.Size = new Size(60, 16);
            paintSpeed.TabIndex = 9;
            paintSpeed.Text = "50";
            paintSpeed.TextChanged += paintSpeed_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(156, 126, 197);
            label1.Location = new Point(12, 325);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 10;
            label1.Text = "Задержка при печати (мс)";
            // 
            // zoneSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(875, 537);
            Controls.Add(label1);
            Controls.Add(paintSpeed);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Name = "zoneSelector";
            StartPosition = FormStartPosition.Manual;
            Text = "выберите зону";
            Load += zoneSelector_Load;
            Shown += zoneSelector_Shown;
            Click += zoneSelector_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox paintSpeed;
        private Label label1;
    }
}