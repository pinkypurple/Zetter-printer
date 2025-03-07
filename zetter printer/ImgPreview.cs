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
    public partial class ImgPreview : Form
    {
        public ImgPreview()
        {
            InitializeComponent();
        }

        private void ImgPreview_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
        public void SetImage(Bitmap bmp)
        {
            img.Image = bmp;
            Width = bmp.Width;
            Height = bmp.Height;
        }
    }
}
