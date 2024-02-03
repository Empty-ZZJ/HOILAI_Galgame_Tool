using HOILAI_Galgame_Tool.SDK.OCR;
using Sunny.UI;
using System.Text;
using static HOILAI_Galgame_Tool.SDK.WinHook;

namespace HOILAI_Galgame_Tool.Pages
{
    public partial class Page_Index : UIPage
    {

        public struct WindowProperties
        {
            public nint hWnd;
            public string name;

        }
        public static bool IsRunning;
        public static WindowProperties NowWindowProperties;
        public static List<WindowProperties> Find_Res = new();
        public static WinRectHelper.WinRectInfo NowWinInfo = new();
        public Page_Index ()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Button_Refresh_Click (object sender, EventArgs e)
        {
            Loading.Visible = true;
            Thread _Refresh = new(() =>
            {
                ComboBox_HWND.Items.Clear();
                Find_Res.Clear();
                EnumWindows((hWnd, lParam) =>
                    {
                        if (IsWindowVisible(hWnd))
                        {

                            int length = GetWindowTextLength(hWnd);
                            if (length > 0)
                            {

                                StringBuilder sb = new StringBuilder(99);
                                GetWindowText(hWnd, sb, 99);
                                string title = sb.ToString();
                                ComboBox_HWND.Items.Add($"{hWnd} - {title}");
                                Find_Res.Add(new WindowProperties { hWnd = hWnd, name = title });
                            }
                        }
                        return true;
                    }, IntPtr.Zero);
                UIMessageBox.Show("加载完成，请选择窗口", true, true);
                Loading.Visible = false;


            });
            _Refresh.Start();

        }

        private void ComboBox_HWND_SelectedIndexChanged (object sender, EventArgs e)
        {
            var _hwnd = Find_Res[ComboBox_HWND.SelectedIndex];
            TextBox_Hwnd.Text = _hwnd.hWnd.ToString();
            TextBox_Name.Text = _hwnd.name;
            NowWindowProperties = _hwnd;
        }

        private void Page_Index_Initialize (object sender, EventArgs e)
        {
        }

        private void Switch_Open_Click (object sender, EventArgs e)
        {
            //不解释为什么不是！Active
            //（因为在你点击的时候已经切换完毕了）
            if (!Switch_Open.Active)
            {
                IsRunning = false;
                return;
            }

            IsRunning = true;

            NowWinInfo = WinRectHelper.GetWinRectInfo(NowWindowProperties.hWnd);
            var _form = new Page_Trans();
            _form.Show();
            //  var _gdi = new GDI_TextDraw(_info.x, _info.y, _info.width, _info.height, "花濑Galgame翻译 准备就绪");
            Thread _TransCore = new(() =>
            {

                while (true)
                {


                    //预览.Image = WindowCaptureHelper.GetShotCutImage(NowWindowProperties.hWnd);
                    Thread.Sleep(100);
                }
            });
            _TransCore.Start();




        }
    }
}
