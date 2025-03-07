using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zetter_printer
{
    public class screenZone
    {
        Rectangle zone;
        Point hexLocation;

        screenZone()
        {
            zone = new Rectangle(0, 0, 0, 0);
            hexLocation = new Point(0, 0);
        }

        public static void UISelect(mainForm p)
        {
            screenZone z = new screenZone();
            zoneSelector zs = new zoneSelector();

            MessageBoxC msNoWindow = new MessageBoxC();
            msNoWindow.setMessage("Окно майнкрафта не найдено");

            MessageBoxC msError = new MessageBoxC();
            msError.setMessage("Возникла непредвиденная ошибка [сообщите пинки]");

            MessageBoxC msNoMinecraft = new MessageBoxC();
            msNoMinecraft.setMessage("Откройте майнкрафт в оконном режиме (маленькое окно).");

            IntPtr hWnd = WinGetHandle("Minecraft");
            if (hWnd == IntPtr.Zero)
            {
                msNoWindow.ShowDialog();
                return;
            }

            Rectangle? layout = getWndRect(new HandleRef(null, hWnd));

            if(layout == null)
            {
                msError.ShowDialog();
                return;
            }


            if(layout.Value.X < 0 || layout.Value.Y < 0)
            {
                msNoMinecraft.ShowDialog();
                return;
            }

            p.WindowState = FormWindowState.Minimized;
            Bitmap bmp = new Bitmap(layout.Value.Width, layout.Value.Height);
            Graphics g = Graphics.FromImage(bmp);//Graphics.FromHwnd(zs.Handle);
            SetForegroundWindow(hWnd);
            Thread.Sleep(50);
            g.CopyFromScreen(new Point(layout.Value.Left, layout.Value.Top), new Point(0, 0), new Size(layout.Value.Width, layout.Value.Height));
            g.FillRectangle(new SolidBrush(Color.FromArgb(150, 0, 0, 0)), 0, 0, layout.Value.Width, layout.Value.Height);
            g.Dispose();

            
            zs.TopMost = true;
            zs.FormBorderStyle = FormBorderStyle.None;

            zs.bg = bmp;
            zs.Left = layout.Value.Left;
            zs.Top = layout.Value.Top;
            zs.Width = layout.Value.Width;
            zs.Height = layout.Value.Height;
            zs.getParent(p);
            zs.Show();
        }

        public static IntPtr WinGetHandle(string wName)
        {
            foreach (Process pList in Process.GetProcesses())
                if (pList.MainWindowTitle.Contains(wName))
                    return pList.MainWindowHandle;

            return IntPtr.Zero;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public static Rectangle? getWndRect(HandleRef hWnd)
        {
            RECT rct;
            Rectangle myRect = new Rectangle();

            if (!GetWindowRect(hWnd, out rct))
            {
                return null;
            }

            myRect.X = rct.Left;
            myRect.Y = rct.Top;
            myRect.Width = rct.Right - rct.Left;
            myRect.Height = rct.Bottom - rct.Top;

            return myRect;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
