namespace zetter_printer
{
    partial class MessageBoxC
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
            okButton = new Button();
            message = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(52, 35);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(12, 9);
            message.Name = "message";
            message.Size = new Size(38, 15);
            message.TabIndex = 1;
            message.Text = "label1";
            // 
            // MessageBoxC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 61);
            Controls.Add(message);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MessageBoxC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxC";
            Load += MessageBoxC_Load;
            Shown += MessageBoxC_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label message;
    }
}