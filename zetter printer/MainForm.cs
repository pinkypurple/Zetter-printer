using System.Diagnostics;
using System.Runtime.InteropServices;

namespace zetter_printer
{
    public partial class mainForm : Form
    {
        Bitmap? canvas = null;
        Painter p = new Painter();
        ImgPreview preview = new ImgPreview();
        public IntPtr minecraftWnd;

        int canCountX = 1;
        int canCountY = 1;
        int curCanX = 1;
        int curCanY = 1;
        public mainForm()
        {
            InitializeComponent();

            this.FormClosed += CloseHandler;
            this.KeyPreview = true;
        }
        private void CloseHandler(object? sender, EventArgs e)
        {
            if (File.Exists("preview.png"))
            {
                File.Delete("preview.png");
            }
        }

        private void targetImage_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            targetImage.Image = Image.FromFile(openImageDialog.FileName);

            // Jumping around c# graphics bugs
            if (targetImage.Image.Width > 1000 || targetImage.Image.Height > 1000)
            {
                int newWidth = 1000;
                int newHeight = (int)((float)targetImage.Image.Height / (float)targetImage.Image.Width * 1000);
                targetImage.Image = ImgProccesor.ResizeImage(targetImage.Image, newWidth, newHeight);
            }


            toolPanel.Enabled = true;
            previewButton.Enabled = true;
            checkBox1.Enabled = true;

            updateCanvas();

            Bitmap bmp = (Bitmap)resultImage.Image;
            preview.SetImage(bmp);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            screenZone.UISelect(this);

            this.WindowState = FormWindowState.Normal;
        }

        public void painter(Point p1, Point p2, Point hp, Point origin, int latency)
        {
            p.p1 = p1;
            p.p2 = p2;
            p.hp = hp;
            p.origin = origin;
            p.latency = latency;
            p.canvas = canvas;
            p.curCanX = curCanX - 1;
            p.curCanY = curCanY - 1;
            p.minecraftWnd = minecraftWnd;
            p.titleHeight = Math.Abs(this.RectangleToScreen(this.ClientRectangle).Top - this.Top);

            p.Draw();
        }

        private void canvasCountX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                canCountX = (int)uint.Parse(canvasCountX.Text);
            }
            catch
            {
                canvasCountX.Text = "";
            }

            if (canCountX > 32)
            {
                canCountX = 32;
                canvasCountX.Text = canCountX.ToString();
            }
            else if (canCountX == 0)
            {
                canCountX = 1;
                canvasCountX.Text = canCountX.ToString();
            }

            if (checkBox1.Checked)
                canCountX *= 2;

            updateCanvas();
            Bitmap bmp = (Bitmap)resultImage.Image;
            preview.SetImage(bmp);
        }

        private void canvasCountY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                canCountY = (int)uint.Parse(canvasCountY.Text);
            }
            catch
            {
                canvasCountY.Text = "";
            }

            if (canCountY > 32)
            {
                canCountY = 32;
                canvasCountY.Text = canCountY.ToString();
            }
            else if(canCountY == 0)
            {
                canCountY = 1;
                canvasCountY.Text = canCountY.ToString();
            }

            if (checkBox1.Checked)
                canCountY *= 2;

            updateCanvas();
            Bitmap bmp = (Bitmap)resultImage.Image;
            preview.SetImage(bmp);
        }

        private void canvasNumX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                curCanX = (int)uint.Parse(canvasNumX.Text);
            }
            catch
            {
                canvasNumX.Text = "";
            }

            if (curCanX > canCountX)
            {
                curCanX = canCountX;
                canvasNumX.Text = curCanX.ToString();
            }
            else if(curCanX == 0)
            {
                curCanX = 1;
                canvasNumX.Text = curCanX.ToString();
            }

            updateCanvas();
        }

        private void canvasNumY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                curCanY = (int)uint.Parse(canvasNumY.Text);
            }
            catch
            {
                canvasNumY.Text = "";
            }

            if (curCanY > canCountX)
            {
                curCanY = canCountX;
                canvasNumY.Text = curCanY.ToString();
            }
            else if (curCanY == 0)
            {
                curCanY = 1;
                canvasNumY.Text = curCanY.ToString();
            }

            updateCanvas();
        }

        private void updateCanvas()
        {
            canvas = ImgProccesor.ImgToCanvasZoomIn((Bitmap)targetImage.Image, canCountX, canCountY);
            resultImage.Image = ImgProccesor.LinearScale(canvas, targetImage.Width * 5 / canvas.Width, targetImage.Width * 5 / canvas.Width);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (canvas == null)
            {
                return;
            }

            preview.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            p.doubleX = checkBox1.Checked;
            p.doubleY = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                canCountX *= 2;
                canCountY *= 2;
            }
            else
            {
                canCountX = (int)MathF.Round(canCountX / 2f);
                canCountY = (int)MathF.Round(canCountY / 2f);
            }
            updateCanvas();
        }
    }
}
