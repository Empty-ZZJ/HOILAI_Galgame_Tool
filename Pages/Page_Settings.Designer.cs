namespace HOILAI_Galgame_Tool.Pages
{
    partial class Page_Settings
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
            Label_1 = new Sunny.UI.UILabel();
            TextBox_id_trans = new Sunny.UI.UITextBox();
            TextBox_key_trans = new Sunny.UI.UITextBox();
            uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            uiLinkLabel4 = new Sunny.UI.UILinkLabel();
            TextBox_key_ocr = new Sunny.UI.UITextBox();
            TextBox_id_ocr = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            CheckBox_使用自己的API_翻译 = new Sunny.UI.UICheckBox();
            CheckBox_使用花濑提供的API_翻译 = new Sunny.UI.UICheckBox();
            CheckBox_使用自己的API_OCR = new Sunny.UI.UICheckBox();
            CheckBox_使用花濑提供的API_OCR = new Sunny.UI.UICheckBox();
            Button_Save = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // Label_1
            // 
            Label_1.Font = new Font("黑体", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_1.ForeColor = Color.FromArgb(48, 48, 48);
            Label_1.Location = new Point(12, 9);
            Label_1.Name = "Label_1";
            Label_1.Size = new Size(862, 46);
            Label_1.TabIndex = 0;
            Label_1.Text = "百度翻译API设置";
            Label_1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextBox_id_trans
            // 
            TextBox_id_trans.Enabled = false;
            TextBox_id_trans.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_id_trans.Location = new Point(17, 138);
            TextBox_id_trans.Margin = new Padding(4, 5, 4, 5);
            TextBox_id_trans.MinimumSize = new Size(1, 16);
            TextBox_id_trans.Name = "TextBox_id_trans";
            TextBox_id_trans.Padding = new Padding(5);
            TextBox_id_trans.ShowText = false;
            TextBox_id_trans.Size = new Size(424, 44);
            TextBox_id_trans.TabIndex = 3;
            TextBox_id_trans.Text = "输入你的appId";
            TextBox_id_trans.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_id_trans.Watermark = "";
            // 
            // TextBox_key_trans
            // 
            TextBox_key_trans.Enabled = false;
            TextBox_key_trans.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_key_trans.Location = new Point(449, 138);
            TextBox_key_trans.Margin = new Padding(4, 5, 4, 5);
            TextBox_key_trans.MinimumSize = new Size(1, 16);
            TextBox_key_trans.Name = "TextBox_key_trans";
            TextBox_key_trans.Padding = new Padding(5);
            TextBox_key_trans.ShowText = false;
            TextBox_key_trans.Size = new Size(428, 44);
            TextBox_key_trans.TabIndex = 4;
            TextBox_key_trans.Text = "输入你的secretKey";
            TextBox_key_trans.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_key_trans.Watermark = "";
            // 
            // uiLinkLabel1
            // 
            uiLinkLabel1.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            uiLinkLabel1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLinkLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            uiLinkLabel1.Location = new Point(17, 205);
            uiLinkLabel1.Name = "uiLinkLabel1";
            uiLinkLabel1.Size = new Size(414, 34);
            uiLinkLabel1.TabIndex = 5;
            uiLinkLabel1.TabStop = true;
            uiLinkLabel1.Text = "点我打开百度翻译API官网";
            uiLinkLabel1.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            uiLinkLabel1.Click += uiLinkLabel1_Click;
            // 
            // uiLinkLabel4
            // 
            uiLinkLabel4.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            uiLinkLabel4.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiLinkLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLinkLabel4.LinkBehavior = LinkBehavior.AlwaysUnderline;
            uiLinkLabel4.Location = new Point(18, 429);
            uiLinkLabel4.Name = "uiLinkLabel4";
            uiLinkLabel4.Size = new Size(414, 34);
            uiLinkLabel4.TabIndex = 12;
            uiLinkLabel4.TabStop = true;
            uiLinkLabel4.Text = "点我前往百度智能云获取API";
            uiLinkLabel4.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            uiLinkLabel4.Click += uiLinkLabel4_Click;
            // 
            // TextBox_key_ocr
            // 
            TextBox_key_ocr.Enabled = false;
            TextBox_key_ocr.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_key_ocr.Location = new Point(450, 369);
            TextBox_key_ocr.Margin = new Padding(4, 5, 4, 5);
            TextBox_key_ocr.MinimumSize = new Size(1, 16);
            TextBox_key_ocr.Name = "TextBox_key_ocr";
            TextBox_key_ocr.Padding = new Padding(5);
            TextBox_key_ocr.ShowText = false;
            TextBox_key_ocr.Size = new Size(428, 44);
            TextBox_key_ocr.TabIndex = 11;
            TextBox_key_ocr.Text = "输入你的sSecret Key";
            TextBox_key_ocr.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_key_ocr.Watermark = "";
            // 
            // TextBox_id_ocr
            // 
            TextBox_id_ocr.Enabled = false;
            TextBox_id_ocr.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_id_ocr.Location = new Point(18, 369);
            TextBox_id_ocr.Margin = new Padding(4, 5, 4, 5);
            TextBox_id_ocr.MinimumSize = new Size(1, 16);
            TextBox_id_ocr.Name = "TextBox_id_ocr";
            TextBox_id_ocr.Padding = new Padding(5);
            TextBox_id_ocr.ShowText = false;
            TextBox_id_ocr.Size = new Size(424, 44);
            TextBox_id_ocr.TabIndex = 10;
            TextBox_id_ocr.Text = "输入你的API Key";
            TextBox_id_ocr.TextAlignment = ContentAlignment.MiddleLeft;
            TextBox_id_ocr.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("黑体", 14F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(13, 256);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(862, 46);
            uiLabel1.TabIndex = 7;
            uiLabel1.Text = "百度OCR设置";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CheckBox_使用自己的API_翻译
            // 
            CheckBox_使用自己的API_翻译.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用自己的API_翻译.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用自己的API_翻译.Location = new Point(450, 84);
            CheckBox_使用自己的API_翻译.MinimumSize = new Size(1, 1);
            CheckBox_使用自己的API_翻译.Name = "CheckBox_使用自己的API_翻译";
            CheckBox_使用自己的API_翻译.Size = new Size(222, 46);
            CheckBox_使用自己的API_翻译.TabIndex = 16;
            CheckBox_使用自己的API_翻译.Text = "使用我自己的API";
            CheckBox_使用自己的API_翻译.Click += CheckBox_使用自己的API_翻译_Click;
            // 
            // CheckBox_使用花濑提供的API_翻译
            // 
            CheckBox_使用花濑提供的API_翻译.Checked = true;
            CheckBox_使用花濑提供的API_翻译.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用花濑提供的API_翻译.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用花濑提供的API_翻译.Location = new Point(17, 84);
            CheckBox_使用花濑提供的API_翻译.MinimumSize = new Size(1, 1);
            CheckBox_使用花濑提供的API_翻译.Name = "CheckBox_使用花濑提供的API_翻译";
            CheckBox_使用花濑提供的API_翻译.Size = new Size(240, 46);
            CheckBox_使用花濑提供的API_翻译.TabIndex = 15;
            CheckBox_使用花濑提供的API_翻译.Text = "使用花濑提供的API";
            CheckBox_使用花濑提供的API_翻译.Click += CheckBox_使用花濑提供的API_翻译_Click;
            // 
            // CheckBox_使用自己的API_OCR
            // 
            CheckBox_使用自己的API_OCR.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用自己的API_OCR.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用自己的API_OCR.Location = new Point(450, 315);
            CheckBox_使用自己的API_OCR.MinimumSize = new Size(1, 1);
            CheckBox_使用自己的API_OCR.Name = "CheckBox_使用自己的API_OCR";
            CheckBox_使用自己的API_OCR.Size = new Size(222, 46);
            CheckBox_使用自己的API_OCR.TabIndex = 18;
            CheckBox_使用自己的API_OCR.Text = "使用我自己的API";
            CheckBox_使用自己的API_OCR.Click += CheckBox_使用自己的API_OCR_Click;
            // 
            // CheckBox_使用花濑提供的API_OCR
            // 
            CheckBox_使用花濑提供的API_OCR.Checked = true;
            CheckBox_使用花濑提供的API_OCR.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用花濑提供的API_OCR.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用花濑提供的API_OCR.Location = new Point(18, 315);
            CheckBox_使用花濑提供的API_OCR.MinimumSize = new Size(1, 1);
            CheckBox_使用花濑提供的API_OCR.Name = "CheckBox_使用花濑提供的API_OCR";
            CheckBox_使用花濑提供的API_OCR.Size = new Size(240, 46);
            CheckBox_使用花濑提供的API_OCR.TabIndex = 17;
            CheckBox_使用花濑提供的API_OCR.Text = "使用花濑提供的API";
            CheckBox_使用花濑提供的API_OCR.Click += CheckBox_使用花濑提供的API_OCR_Click;
            // 
            // Button_Save
            // 
            Button_Save.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Save.Location = new Point(696, 551);
            Button_Save.MinimumSize = new Size(1, 1);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(150, 52);
            Button_Save.TabIndex = 19;
            Button_Save.Text = "保存";
            Button_Save.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Button_Save.Click += Button_Save_Click;
            // 
            // Page_Settings
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(886, 642);
            Controls.Add(Button_Save);
            Controls.Add(CheckBox_使用自己的API_OCR);
            Controls.Add(CheckBox_使用花濑提供的API_OCR);
            Controls.Add(CheckBox_使用自己的API_翻译);
            Controls.Add(CheckBox_使用花濑提供的API_翻译);
            Controls.Add(uiLinkLabel4);
            Controls.Add(TextBox_key_ocr);
            Controls.Add(TextBox_id_ocr);
            Controls.Add(uiLabel1);
            Controls.Add(uiLinkLabel1);
            Controls.Add(TextBox_key_trans);
            Controls.Add(TextBox_id_trans);
            Controls.Add(Label_1);
            Name = "Page_Settings";
            PageIndex = 2;
            Text = "Page_Settings";
            Initialize += Page_Settings_Initialize;
            Load += Page_Settings_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel Label_1;
        private Sunny.UI.UITextBox TextBox_id_trans;
        private Sunny.UI.UITextBox TextBox_key_trans;
        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private Sunny.UI.UILinkLabel uiLinkLabel4;
        private Sunny.UI.UITextBox TextBox_key_ocr;
        private Sunny.UI.UITextBox TextBox_id_ocr;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UICheckBox CheckBox_使用自己的API_翻译;
        private Sunny.UI.UICheckBox CheckBox_使用花濑提供的API_翻译;
        private Sunny.UI.UICheckBox CheckBox_使用自己的API_OCR;
        private Sunny.UI.UICheckBox CheckBox_使用花濑提供的API_OCR;
        private Sunny.UI.UIButton Button_Save;
    }
}