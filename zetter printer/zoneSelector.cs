using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Graphics.Imaging;

namespace zetter_printer
{
    public partial class zoneSelector : Form
    {
        const string confPath = "screen zone.json";
        public drawConfig dConf = new drawConfig();
        public Rectangle canvasRegion;
        public Bitmap bg;

        mainForm? prnt = null;

        Graphics? g;

        enum curSelect
        {
            angle1 = 0,
            angle2 = 1,
            hex = 2,
            none = 3
        }

        curSelect cs = curSelect.none;


        //      *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *
        //
        //      Very cool init metod indeed (I keep losing it so I added this giant comment, yea)
        //
        //      *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *
        public zoneSelector()
        {
            InitializeComponent();

            dConf.p1 = new Point(100, 100);
            dConf.p2 = new Point(200, 200);
            dConf.hp = new Point(300, 300);
            dConf.origin = new Point(-1000, -1000);
            dConf.latency = 50;

            if (File.Exists(confPath))
            {
                string s = File.ReadAllText(confPath);
                dConf = Newtonsoft.Json.JsonConvert.DeserializeObject<drawConfig>(s);
            }

            paintSpeed.Text = dConf.latency.ToString();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        public void getParent(mainForm p)
        {
            this.prnt = p;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cs = curSelect.angle1;
            updateToolButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs = curSelect.angle2;
            updateToolButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs = curSelect.hex;
            updateToolButtons();
        }

        private void updateToolButtons()
        {
            button3.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;

            switch (cs)
            {
                case curSelect.angle1: button3.FlatAppearance.BorderSize = 2; break;
                case curSelect.angle2: button2.FlatAppearance.BorderSize = 2; break;
                case curSelect.hex: button1.FlatAppearance.BorderSize = 2; break;
            }
        }

        private void zoneSelector_Load(object sender, EventArgs e)
        {

        }

        private void zoneSelector_Click(object sender, EventArgs e)
        {
            bool update = true;
            switch (cs)
            {
                case curSelect.angle1: dConf.p1.X = MousePosition.X - this.Left; dConf.p1.Y = MousePosition.Y - this.Top; break;
                case curSelect.angle2: dConf.p2.X = MousePosition.X - this.Left; dConf.p2.Y = MousePosition.Y - this.Top; break;
                case curSelect.hex: dConf.hp.X = MousePosition.X - this.Left; dConf.hp.Y = MousePosition.Y - this.Top; break;
            }

            if (update)
            {
                if (dConf.p2.X < dConf.p1.X)
                {
                    int temp = dConf.p2.X;
                    dConf.p2.X = dConf.p1.X;
                    dConf.p1.X = temp;
                }

                if (dConf.p2.Y < dConf.p1.Y)
                {
                    int temp = dConf.p2.Y;
                    dConf.p2.Y = dConf.p1.Y;
                    dConf.p1.Y = temp;
                }

                drawDots();
            }
        }

        public void drawDots()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (bg != null)
            {
                g.DrawImage(this.bg, 0, 0);
                g.FillRectangle(new SolidBrush(ColorTheme.TransparentBlack), 0, 0, this.Width, this.Height);
            }


            Brush br = new SolidBrush(Color.FromArgb(203, 196, 255));           // Main brush
            Brush brTr = new SolidBrush(Color.FromArgb(40, ColorTheme.Accent)); // Transparent brush

            g.FillEllipse(br, dConf.p1.X - 4, dConf.p1.Y - 4, 8, 8);
            g.FillEllipse(br, dConf.p2.X - 4, dConf.p2.Y - 4, 8, 8);

            g.FillEllipse(brTr, dConf.hp.X - 20, dConf.hp.Y - 20, 40, 40);
            g.FillEllipse(brTr, dConf.hp.X - 10, dConf.hp.Y - 10, 20, 20);
            g.FillEllipse(br, dConf.hp.X - 4, dConf.hp.Y - 4, 8, 8);

            g.FillRectangle(brTr, dConf.p1.X, dConf.p1.Y, Math.Abs(dConf.p2.X - dConf.p1.X), Math.Abs(dConf.p1.Y - dConf.p2.Y));
            g.DrawRectangle(new Pen(br, 2), dConf.p1.X, dConf.p1.Y, Math.Abs(dConf.p2.X - dConf.p1.X), Math.Abs(dConf.p1.Y - dConf.p2.Y));
            g.Dispose();

            this.BackgroundImage = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point origin = new Point(Left, Top);
            dConf.origin = origin;

            this.WindowState = FormWindowState.Minimized;

            if (prnt != null)
            {
                prnt.painter(dConf.p1, dConf.p2, dConf.hp, dConf.origin, dConf.latency);
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dConf);
            File.WriteAllText(confPath, json);
            this.Close();
        }

        private void zoneSelector_Shown(object sender, EventArgs e)
        { 
            drawDots();
        }

        private void paintSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dConf.latency = int.Parse(paintSpeed.Text);
                if (dConf.latency == 0)
                {
                    dConf.latency = 1;
                    paintSpeed.Text = "1";
                }
            }
            catch
            {
                paintSpeed.Text = "";
            }
        }
        private void findCanvasBounds()
        {
            if (bg.GetPixel(Width / 2, Height / 2) != ColorTheme.Canvas)
            {
                return;
            }

            int left = Width / 2;
            int right = Width / 2;
            int bottom = Height / 2;
            int top = Height / 2;

            for (int i = left; i > 0; i--) // finding the left border of a canvas
            {
                if (bg.GetPixel(i, Height / 2) != ColorTheme.Canvas)
                {
                    left = i + 1;
                    break;
                }
            }

            for (int i = right; i < Width; i++) // finding the right border of a canvas
            {
                if (bg.GetPixel(i, Height / 2) != ColorTheme.Canvas)
                {
                    right = i - 1;
                    break;
                }
            }

            for (int i = top; i > 0; i--) // finding the top border of a canvas
            {
                if (bg.GetPixel(Width / 2, i) != ColorTheme.Canvas)
                {
                    top = i + 1;
                    break;
                }
            }

            for (int i = bottom; i < Height; i++) // finding the bottom border of a canvas
            {
                if (bg.GetPixel(Width / 2, i) != ColorTheme.Canvas)
                {
                    bottom = i + 1;
                    break;
                }
            }

            dConf.p1 = new Point(left, top);
            dConf.p2 = new Point(right, bottom);

            drawDots();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            findCanvasBounds();
        }
    }
    public class drawConfig
    {
        public Point p1;
        public Point p2;
        public Point hp;
        public Point origin;

        public int latency;
    }
}