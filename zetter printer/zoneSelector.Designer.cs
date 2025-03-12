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
            button6 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(32, 32, 32);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(156, 126, 197);
            button4.Location = new Point(822, 629);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(165, 31);
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
            button5.Location = new Point(14, 16);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(69, 41);
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
            button1.Location = new Point(14, 625);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 31);
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
            button2.Location = new Point(14, 587);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(201, 31);
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
            button3.Location = new Point(14, 548);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(201, 31);
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
            paintSpeed.Location = new Point(14, 457);
            paintSpeed.Margin = new Padding(3, 4, 3, 4);
            paintSpeed.MaxLength = 3;
            paintSpeed.Name = "paintSpeed";
            paintSpeed.Size = new Size(69, 20);
            paintSpeed.TabIndex = 9;
            paintSpeed.Text = "50";
            paintSpeed.TextChanged += paintSpeed_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(156, 126, 197);
            label1.Location = new Point(14, 433);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 10;
            label1.Text = "Задержка при печати (мс)";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(32, 32, 32);
            button6.FlatAppearance.BorderColor = Color.FromArgb(156, 126, 197);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(156, 126, 197);
            button6.Location = new Point(761, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(227, 31);
            button6.TabIndex = 11;
            button6.Text = "Определить автоматически";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // zoneSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(1000, 716);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(paintSpeed);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button6;
    }
}