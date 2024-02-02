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
            CheckBox_使用花濑提供的API = new Sunny.UI.UICheckBox();
            CheckBox_使用自己的API = new Sunny.UI.UICheckBox();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // Label_1
            // 
            Label_1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label_1.ForeColor = Color.FromArgb(48, 48, 48);
            Label_1.Location = new Point(12, 9);
            Label_1.Name = "Label_1";
            Label_1.Size = new Size(862, 46);
            Label_1.TabIndex = 0;
            Label_1.Text = "Token设置";
            Label_1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CheckBox_使用花濑提供的API
            // 
            CheckBox_使用花濑提供的API.Checked = true;
            CheckBox_使用花濑提供的API.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用花濑提供的API.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用花濑提供的API.Location = new Point(12, 75);
            CheckBox_使用花濑提供的API.MinimumSize = new Size(1, 1);
            CheckBox_使用花濑提供的API.Name = "CheckBox_使用花濑提供的API";
            CheckBox_使用花濑提供的API.Size = new Size(240, 46);
            CheckBox_使用花濑提供的API.TabIndex = 1;
            CheckBox_使用花濑提供的API.Text = "使用花濑提供的API";
            // 
            // CheckBox_使用自己的API
            // 
            CheckBox_使用自己的API.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBox_使用自己的API.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox_使用自己的API.Location = new Point(445, 75);
            CheckBox_使用自己的API.MinimumSize = new Size(1, 1);
            CheckBox_使用自己的API.Name = "CheckBox_使用自己的API";
            CheckBox_使用自己的API.Size = new Size(222, 46);
            CheckBox_使用自己的API.TabIndex = 2;
            CheckBox_使用自己的API.Text = "使用我自己的API";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Enabled = false;
            uiTextBox1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(13, 141);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(424, 44);
            uiTextBox1.TabIndex = 3;
            uiTextBox1.Text = "输入你的appId";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Enabled = false;
            uiTextBox2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.Location = new Point(445, 141);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(428, 44);
            uiTextBox2.TabIndex = 4;
            uiTextBox2.Text = "输入你的secretKey";
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // Page_Settings
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(886, 642);
            Controls.Add(uiTextBox2);
            Controls.Add(uiTextBox1);
            Controls.Add(CheckBox_使用自己的API);
            Controls.Add(CheckBox_使用花濑提供的API);
            Controls.Add(Label_1);
            Name = "Page_Settings";
            PageIndex = 2;
            Text = "Page_Settings";
            Load += Page_Settings_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel Label_1;
        private Sunny.UI.UICheckBox CheckBox_使用花濑提供的API;
        private Sunny.UI.UICheckBox CheckBox_使用自己的API;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox2;
    }
}