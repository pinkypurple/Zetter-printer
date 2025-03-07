using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zetter_printer
{
    public static class ImgProccesor
    {
        const int canvasSizeX = 16;
        const int canvasSizeY = canvasSizeX;
        public static Bitmap ImgToCanvasZoomIn(Bitmap source, int canvasCountX, int canvasCountY)
        {
            Bitmap bmp = new Bitmap(canvasSizeX * canvasCountX, canvasSizeY * canvasCountY);

            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawImage(source, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();

            return bmp;
        }

        public static Bitmap LinearScale(Bitmap src, float scaleX, float scaleY)
        {
            Bitmap bmp = new Bitmap((int)(scaleX * src.Width), (int)(scaleY * src.Height));
            Graphics g = Graphics.FromImage(bmp);

            // This is terrible code, but winforms just can't draw without smoothing on
            float pxPerUnitX = (float)bmp.Width / (src.Width);
            float pxPerUnitY = (float)bmp.Height / (src.Height);

            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Brush br = new SolidBrush(src.GetPixel(i, j));
                    g.FillRectangle(br, i * pxPerUnitX, j * pxPerUnitY, pxPerUnitX, pxPerUnitY);
                }
            }

            return bmp;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static string ColorToHex(Color c)
        {
            return $"{c.R:X2}{c.G:X2}{c.B:X2}";
        }
    }
}
