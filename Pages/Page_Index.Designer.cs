namespace HOILAI_Galgame_Tool.Pages
{
    partial class Page_Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Index));
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            Loading = new PictureBox();
            Button_Refresh = new Sunny.UI.UIButton();
            ComboBox_HWND = new Sunny.UI.UIComboBox();
            uiLabel7 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            TextBox_Name = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            TextBox_Hwnd = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            Switch_Open = new Sunny.UI.UISwitch();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            预览 = new PictureBox();
            uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loading).BeginInit();
            uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)预览).BeginInit();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiTitlePanel1.Controls.Add(Loading);
            uiTitlePanel1.Controls.Add(Button_Refresh);
            uiTitlePanel1.Controls.Add(ComboBox_HWND);
            uiTitlePanel1.Controls.Add(uiLabel7);
            uiTitlePanel1.Controls.Add(uiLabel6);
            uiTitlePanel1.Controls.Add(uiComboBox1);
            uiTitlePanel1.Controls.Add(TextBox_Name);
            uiTitlePanel1.Controls.Add(uiLabel2);
            uiTitlePanel1.Controls.Add(TextBox_Hwnd);
            uiTitlePanel1.Controls.Add(uiLabel1);
            uiTitlePanel1.FillColor = Color.White;
            uiTitlePanel1.FillColor2 = Color.White;
            uiTitlePanel1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(13, 272);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(860, 292);
            uiTitlePanel1.TabIndex = 3;
            uiTitlePanel1.Text = "游戏信息";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTitlePanel1.TitleColor = Color.White;
            uiTitlePanel1.TitleForeColor = Color.Black;
            uiTitlePanel1.TitleHeight = 50;
            // 
            // Loading
            // 
            Loading.Image = (Image)resources.GetObject("Loading.Image");
            Loading.Location = new Point(732, 62);
            Loading.Name = "Loading";
            Loading.Size = new Size(113, 48);
            Loading.SizeMode = PictureBoxSizeMode.Zoom;
            Loading.TabIndex = 29;
            Loading.TabStop = false;
            Loading.Visible = false;
            // 
            // Button_Refresh
            // 
            Button_Refresh.FillColor = Color.White;
            Button_Refresh.FillColor2 = Color.White;
            Button_Refresh.FillHoverColor = Color.White;
            Button_Refresh.FillPressColor = Color.White;
            Button_Refresh.FillSelectedColor = Color.White;
            Button_Refresh.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Refresh.ForeColor = Color.Black;
            Button_Refresh.ForeHoverColor = Color.Black;
            Button_Refresh.ForePressColor = Color.Black;
            Button_Refresh.ForeSelectedColor = Color.Black;
            Button_Refresh.Location = new Point(732, 66);
            Button_Refresh.MinimumSize = new Size(1, 1);
            Button_Refresh.Name = "Button_Refresh";
            Button_Refresh.RectColor = Color.FromArgb(224, 224, 224);
            Button_Refresh.RectHoverColor = Color.Silver;
            Button_Refresh.RectPressColor = Color.FromArgb(224, 224, 224);
            Button_Refresh.RectSelectedColor = Color.FromArgb(224, 224, 224);
            Button_Refresh.Size = new Size(113, 44);
            Button_Refresh.TabIndex = 21;
            Button_Refresh.Text = "刷新";
            Button_Refresh.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Refresh.Click += Button_Refresh_Click;
            // 
            // ComboBox_HWND
            // 
            ComboBox_HWND.DataSource = null;
            ComboBox_HWND.FillColor = Color.White;
            ComboBox_HWND.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_HWND.ItemHeight = 40;
            ComboBox_HWND.ItemHoverColor = Color.FromArgb(155, 200, 255);
            ComboBox_HWND.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            ComboBox_HWND.Location = new Point(152, 66);
            ComboBox_HWND.Margin = new Padding(4, 5, 4, 5);
            ComboBox_HWND.MaxDropDownItems = 999;
            ComboBox_HWND.MinimumSize = new Size(63, 0);
            ComboBox_HWND.Name = "ComboBox_HWND";
            ComboBox_HWND.Padding = new Padding(0, 0, 30, 2);
            ComboBox_HWND.RectColor = Color.FromArgb(224, 224, 224);
            ComboBox_HWND.ScrollBarColor = Color.Silver;
            ComboBox_HWND.ScrollBarStyleInherited = false;
            ComboBox_HWND.Size = new Size(561, 44);
            ComboBox_HWND.TabIndex = 6;
            ComboBox_HWND.Text = "选择窗口";
            ComboBox_HWND.TextAlignment = ContentAlignment.MiddleLeft;
            ComboBox_HWND.TrimFilter = true;
            ComboBox_HWND.Watermark = "";
            ComboBox_HWND.SelectedIndexChanged += ComboBox_HWND_SelectedIndexChanged;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Location = new Point(21, 66);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(124, 44);
            uiLabel7.TabIndex = 7;
            uiLabel7.Text = "选择游戏:";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(21, 228);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(124, 44);
            uiLabel6.TabIndex = 6;
            uiLabel6.Text = "游戏语言:";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiComboBox1.ItemHeight = 40;
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.Items.AddRange(new object[] { "日语", "英语" });
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(152, 228);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MaxDropDownItems = 999;
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.RectColor = Color.FromArgb(224, 224, 224);
            uiComboBox1.ScrollBarColor = Color.Silver;
            uiComboBox1.ScrollBarStyleInherited = false;
            uiComboBox1.Size = new Size(693, 44);
            uiComboBox1.TabIndex = 5;
            uiComboBox1.Text = "日语";
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.TrimFilter = true;
            uiComboBox1.Watermark = "";
            // 
            // TextBox_Name
            // 
            TextBox_Name.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Name.Location = new Point(152, 174);
            TextBox_Name.Margin = new Padding(4, 5, 4, 5);
            TextBox_Name.MinimumSize = new Size(1, 16);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.Padding = new Padding(5);
            TextBox_Name.RectColor = Color.FromArgb(224, 224, 224);
            TextBox_Name.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            TextBox_Name.ShowText = false;
            TextBox_Name.Size = new Size(693, 44);
            TextBox_Name.TabIndex = 4;
            TextBox_Name.Text = "未找到";
            TextBox_Name.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_Name.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(21, 174);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(124, 44);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "窗口名:";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_Hwnd
            // 
            TextBox_Hwnd.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Hwnd.Location = new Point(152, 120);
            TextBox_Hwnd.Margin = new Padding(4, 5, 4, 5);
            TextBox_Hwnd.MinimumSize = new Size(1, 16);
            TextBox_Hwnd.Name = "TextBox_Hwnd";
            TextBox_Hwnd.Padding = new Padding(5);
            TextBox_Hwnd.RectColor = Color.FromArgb(224, 224, 224);
            TextBox_Hwnd.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            TextBox_Hwnd.ShowText = false;
            TextBox_Hwnd.Size = new Size(693, 44);
            TextBox_Hwnd.TabIndex = 1;
            TextBox_Hwnd.Text = "未找到";
            TextBox_Hwnd.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_Hwnd.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(21, 120);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(124, 44);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "游戏句柄:";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Switch_Open
            // 
            Switch_Open.ActiveText = "开启";
            Switch_Open.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Switch_Open.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            Switch_Open.InActiveText = "关闭";
            Switch_Open.Location = new Point(761, 586);
            Switch_Open.MinimumSize = new Size(1, 1);
            Switch_Open.Name = "Switch_Open";
            Switch_Open.Size = new Size(112, 44);
            Switch_Open.TabIndex = 4;
            Switch_Open.Text = "uiSwitch1";
            Switch_Open.Click += Switch_Open_Click;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiTitlePanel2.Controls.Add(uiLabel5);
            uiTitlePanel2.Controls.Add(uiLabel3);
            uiTitlePanel2.Controls.Add(uiLabel4);
            uiTitlePanel2.FillColor = Color.White;
            uiTitlePanel2.FillColor2 = Color.White;
            uiTitlePanel2.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(13, 14);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.RectColor = Color.FromArgb(224, 224, 224);
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(860, 239);
            uiTitlePanel2.TabIndex = 5;
            uiTitlePanel2.Text = "识别信息";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTitlePanel2.TitleColor = Color.White;
            uiTitlePanel2.TitleForeColor = Color.Black;
            uiTitlePanel2.TitleHeight = 50;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(21, 183);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(377, 44);
            uiLabel5.TabIndex = 6;
            uiLabel5.Text = "识别成功率：100%";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(21, 121);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(377, 44);
            uiLabel3.TabIndex = 5;
            uiLabel3.Text = "识别成功：0 个字符";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(21, 62);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(377, 44);
            uiLabel4.TabIndex = 4;
            uiLabel4.Text = "识别成功：0 个字符";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // 预览
            // 
            预览.Location = new Point(13, 572);
            预览.Name = "预览";
            预览.Size = new Size(145, 58);
            预览.SizeMode = PictureBoxSizeMode.Zoom;
            预览.TabIndex = 6;
            预览.TabStop = false;
            // 
            // Page_Index
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(886, 642);
            Controls.Add(预览);
            Controls.Add(uiTitlePanel2);
            Controls.Add(Switch_Open);
            Controls.Add(uiTitlePanel1);
            Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Page_Index";
            PageIndex = 1;
            Text = "Page_Index";
            Initialize += Page_Index_Initialize;
            uiTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Loading).EndInit();
            uiTitlePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)预览).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox TextBox_Hwnd;
        public Sunny.UI.UISwitch Switch_Open;
        private Sunny.UI.UITextBox TextBox_Name;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox ComboBox_HWND;
        private Sunny.UI.UIButton Button_Refresh;
        private PictureBox Loading;
        private PictureBox 预览;
    }
}