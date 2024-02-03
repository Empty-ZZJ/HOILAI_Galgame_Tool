using System.Runtime.InteropServices;

namespace HOILAI_Galgame_Tool.SDK.OCR
{
    public static class WinRectHelper
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect (IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }
        public class WinRectInfo
        {
            public int width;                   //窗口的宽度
            public int height;                //窗口的高度
            public int x;
            public int y;
        }
        public static WinRectInfo GetWinRectInfo (IntPtr h)
        {
            RECT fx = new RECT();
            GetWindowRect(h, ref fx);//h为窗口句柄
            int width = fx.Right - fx.Left;                        //窗口的宽度
            int height = fx.Bottom - fx.Top;                   //窗口的高度
            int x = fx.Left;
            int y = fx.Top;
            return new WinRectInfo { width = width, height = height, x = x, y = y };
        }
    }
}
