using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zetter_printer
{
    public partial class MessageBoxC : Form
    {
        public MessageBoxC()
        {
            InitializeComponent();
        }

        private void MessageBoxC_Load(object sender, EventArgs e)
        {
            Text = "^-^";
            TopMost = true;
            BackColor = ColorTheme.MainBG;
            okButton.BackColor = ColorTheme.AccentBG;
            message.ForeColor = Color.White;
            okButton.ForeColor = Color.White;

            okButton.FlatStyle = FlatStyle.Flat;
            message.AutoSize = true;

            this.BringToFront();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setMessage(string message)
        {
            this.message.Text = message;
            this.Height = this.message.Height + 100;
            this.Width = this.message.Width + 100;
            this.message.Left = this.Width / 2 - this.message.Width / 2;
        }

        private void MessageBoxC_Shown(object sender, EventArgs e)
        {
            Activate();
        }
    }
}
