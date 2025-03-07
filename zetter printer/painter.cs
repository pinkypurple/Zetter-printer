using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zetter_printer
{
    public class Painter
    {
        public Point p1; 
        public Point p2;
        public Point hp;
        public Point origin;

        public int curCanX;
        public int curCanY;

        public int latency = 50;

        public Bitmap? canvas = null;
        public void draw()
        {
            if (canvas == null)
                return;

            MessageBoxC msAdvise = new MessageBoxC();
            msAdvise.setMessage("Двигайте мышкой, чтобы прекратить рисование");
            msAdvise.ShowDialog();

            MessageBoxC msTermiated = new MessageBoxC();
            msTermiated.setMessage("Прекращено");

            Point paintPoint = new Point();
            Point colorPoint = new Point((int)(origin.X + hp.X), (int)(origin.Y + hp.Y));

            float dx = (p2.X - p1.X) / 16;
            float dy = (p2.Y - p1.Y) / 16;

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                { 
                    Cursor.Position = colorPoint;
                    Thread.Sleep(latency);
                    if (Cursor.Position != colorPoint)
                    {
                        msTermiated.ShowDialog();
                        return;
                    }

                    MouseProcessor.Click(Cursor.Position);

                    SendKeys.Send("^a");

                    Clipboard.SetText(ImgProccesor.ColorToHex(canvas.GetPixel(i + curCanX * 16, j + curCanY * 16)));

                    SendKeys.Send("^v");

                    paintPoint.X = (int)(origin.X + p1.X + dx * i + dx / 2);
                    paintPoint.Y = (int)(origin.Y + p1.Y + dy * j + dy / 2);

                    Cursor.Position = paintPoint;
                    Thread.Sleep(latency);
                    if (Cursor.Position != paintPoint)
                    {
                        msTermiated.ShowDialog();
                        return;
                    }

                    MouseProcessor.Click(Cursor.Position);
                }
            }
            MessageBoxC msCompleted = new MessageBoxC();
            msCompleted.setMessage("Рисунок готов");
            msCompleted.ShowDialog();
        }
    }
}
