using System.Runtime.InteropServices;
using System.Text;

namespace HOILAI_Galgame_Tool.SDK
{
    public static class WinHook
    {
        //获取窗口标题
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText (
        IntPtr hWnd, //窗口句柄
        StringBuilder lpString, //标题
        int nMaxCount  //最大值
        );
        //获取类的名字
        [DllImport("user32.dll")]
        public static extern int GetClassName (
            IntPtr hWnd, //句柄
            StringBuilder lpString, //类名
            int nMaxCount //最大值
        );
        //根据坐标获取窗口句柄
        [DllImport("user32")]
        public static extern IntPtr WindowFromPoint (
        Point Point  //坐标
        );

        [DllImport("user32.dll")]
        public static extern bool EnumWindows (EnumWindowsProc enumProc, IntPtr lParam);

        public delegate bool EnumWindowsProc (IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible (IntPtr hWnd);


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowTextLength (IntPtr hWnd);
    }
}
