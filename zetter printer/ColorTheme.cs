using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zetter_printer
{
    public static class ColorTheme
    {
        // App UI reference colors
        public static Color MainBG = Color.FromArgb(255, 25, 25, 25);
        public static Color AccentBG = Color.FromArgb(255, 32, 32, 32);
        public static Color GrayBG = Color.FromArgb(255, 70, 70, 70);
        public static Color Accent = Color.FromArgb(255, 143, 126, 255);
        public static Color TransparentBlack = Color.FromArgb(180, 0, 0, 0);

        // Zetter reference colors
        public static Color Canvas = Color.FromArgb(255, 221, 215, 204);
    }
}