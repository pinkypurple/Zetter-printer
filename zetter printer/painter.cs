using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.Security.Isolation;

namespace zetter_printer
{
    public class Painter
    {
        //
        //  Don't even ask about it
        //
        const double CC_RATIO = 0.988188976378; // color correction ratio

        enum DrawMode           // describes all the drawing modes
        {
            paste,
            select
        }

        //
        //  Drawing points
        //
        public Point p1;        // Left upper corner of a canvas
        public Point p2;        // Right bottom corner of a canvas
        public Point hp;        // Hex color point of a canvas
        public Point origin;    // Position of a minecraft window

        //
        //  Window specific information
        //
        public IntPtr minecraftWnd;     // Handle to the window
        public int titleHeight = 31;    // Title height of the window

        //
        //  Canvas information
        //
        public int curCanX;             // Number of a drawn canvas by X
        public int curCanY;             // Number of a drawn canvas by Y
        public bool doubleX = false;    // do we draw two canvases by X
        public bool doubleY = false;    // do we draw two canvases by Y
        
        //
        //  Drawing sequence information
        //
        public int latency = 50;                // Wait time after drawing each pixel
        DrawMode drawmode = DrawMode.paste;     // Drawing mode

        //
        //  Source informaion
        //
        public Bitmap? canvas = null;   // Source canvas

        public void Draw()
        {
            if (canvas == null)
                return;

            MessageBoxC msAdvise = new MessageBoxC();
            msAdvise.setMessage("Двигайте мышкой, чтобы прекратить рисование");
            msAdvise.ShowDialog();

            MessageBoxC msTerminated = new MessageBoxC();
            msTerminated.setMessage("Прекращено");

            switch (drawmode)
            {
                case DrawMode.paste: _DrawPaste(msTerminated); break;
                default: break;
            }
        }
        public void _DrawPaste(MessageBoxC msTerminated)
        {
            Bitmap temp = new Bitmap(Screen.GetBounds(Point.Empty).Width, Screen.GetBounds(Point.Empty).Height);

            if (canvas == null)
                return;

            int sizeX, sizeY;

            sizeX = doubleX ? 32 : 16;
            sizeY = doubleY ? 32 : 16;

            float dx = (p2.X - p1.X) / (float)sizeX;
            float dy = (p2.Y - p1.Y) / (float)sizeY;

            Point paintPoint = new Point();
            Point colorPoint = new Point((int)(origin.X + hp.X), (int)(origin.Y + hp.Y));

            Color prevColor = Color.FromArgb(0, 0, 0, 0);
            bool complete = false;

            while (!complete)
            {
                complete = true;
                Graphics g = Graphics.FromImage(temp);
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), temp.Size);
                g.Dispose();
                for (int i = 0; i < sizeX; i++)
                {
                    for (int j = 0; j < sizeY; j++)
                    {
                        Color c1 = temp.GetPixel((int)(origin.X + p1.X + dx * i + dx / 2), (int)(origin.Y + p1.Y + dy * j + dy / 2));
                        Color c2 = canvas.GetPixel(i + curCanX * sizeX, j + curCanY * sizeY);
                        c2 = Color.FromArgb((byte)(Math.Round(c2.R * CC_RATIO)), (byte)(Math.Round(c2.G * CC_RATIO)), (byte)Math.Round((c2.B * CC_RATIO)));

                        if (c1 == c2)
                        {
                            continue;
                        }
                        complete = false;

                        int prevI = i;
                        int prevJ = j - 1;
                        if (j < 0)
                        {
                            j = sizeY - 1;
                            i--;
                        }
                        else if (i < 0)
                        {
                            i = 0;
                            j = 0;
                        }

                        if (canvas.GetPixel(i + curCanX * sizeX, j + curCanY * sizeY) != prevColor)
                        {
                            Cursor.Position = colorPoint;
                            Thread.Sleep(latency);
                            if (Cursor.Position != colorPoint)
                            {
                                msTerminated.ShowDialog();
                                return;
                            }

                            MouseProcessor.Click(Cursor.Position);

                            Thread.Sleep(latency);

                            SendKeys.Send("^a");

                            Clipboard.SetText(ImgProccesor.ColorToHex(canvas.GetPixel(i + curCanX * sizeX, j + curCanY * sizeY)));

                            SendKeys.Send("^v");

                            prevColor = canvas.GetPixel(i + curCanX * sizeX, j + curCanY * sizeY);
                        }

                        paintPoint.X = (int)(origin.X + p1.X + dx * i + dx / 2);
                        paintPoint.Y = (int)(origin.Y + p1.Y + dy * j + dy / 2);

                        Cursor.Position = paintPoint;
                        Thread.Sleep(latency);
                        if (Cursor.Position != paintPoint)
                        {
                            msTerminated.ShowDialog();
                            return;
                        }

                        MouseProcessor.Click(Cursor.Position);
                    }
                }
            }
            MessageBoxC msCompleted = new MessageBoxC();
            msCompleted.setMessage("Рисунок готов");
            msCompleted.ShowDialog();
        }
        public static class ScreenColor
        {
            [DllImport("user32.dll")]
            private static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("gdi32.dll")]
            private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

            [DllImport("user32.dll")]
            private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hdc);

            public static Color GetPixelColor(int x, int y, IntPtr hWnd)
            {
                IntPtr hdc = GetDC(hWnd);
                uint pixel = GetPixel(hdc, x, y);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                (int)(pixel & 0x0000FF00) >> 8,
                (int)(pixel & 0x00FF0000) >> 16);
                return color;
            }
        }
    }
}
