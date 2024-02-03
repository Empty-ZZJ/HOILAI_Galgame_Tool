using System.Runtime.InteropServices;

namespace HOILAI_Galgame_Tool.SDK.GDI
{

    public class GDI_TextDraw
    {
        private static class NativeMethods
        {
            public const int GWL_EXSTYLE = -20;
            public const int WS_EX_TRANSPARENT = 0x00000020;
            public const int WS_EX_TOOLWINDOW = 0x00000080;

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowLong (IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            public static extern int SetWindowLong (IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        }

        private Form _form;
        private string _text;

        public GDI_TextDraw (int x, int y, int width, int height, string text)
        {
            _form = new();
            _form.Location = new Point(x, y);
            _form.Size = new Size(width, height);
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.ShowInTaskbar = false;
            _form.TopMost = true;
            _form.Load += Form_Load;
            _form.Paint += Form_Paint;
            _text = text;

            int exStyle = (int)NativeMethods.GetWindowLong(_form.Handle, NativeMethods.GWL_EXSTYLE);
            exStyle |= NativeMethods.WS_EX_TRANSPARENT | NativeMethods.WS_EX_TOOLWINDOW;
            NativeMethods.SetWindowLong(_form.Handle, NativeMethods.GWL_EXSTYLE, (IntPtr)exStyle);

            _form.Show();
            //_form.ShowDialog();
        }

        private void Form_Load (object sender, EventArgs e)
        {
            _form.Visible = false;
            _form.Opacity = 0.8;
            _form.Visible = true;
        }

        private void Form_Paint (object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // 设置文本颜色和字体
            Color textColor = Color.Black;
            Font textFont = new Font("黑体", 24);

            // 设置底色
            Color backColor = Color.Transparent;
            SolidBrush backBrush = new SolidBrush(backColor);

            // 绘制底色矩形
            g.FillRectangle(backBrush, _form.ClientRectangle);

            // 绘制文本
            g.DrawString(_text, textFont, new SolidBrush(textColor), _form.ClientRectangle, format);
        }

        public void UpdateText (string newText)
        {
            _text = newText;
            _form.Invalidate();
        }
    }
}
