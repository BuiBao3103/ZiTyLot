using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.GUI.component_extensions
{
    public static class RoundedBorder
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
    (
        int nLeft,
        int nTop,
        int nRight,
        int nBottom,
        int nWidth,
        int nHeight
    );
    }
}
