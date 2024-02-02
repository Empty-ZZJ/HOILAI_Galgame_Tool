namespace HOILAI_Galgame_Tool.Pages
{
    partial class Page_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_About));
            uiAvatar2 = new Sunny.UI.UIAvatar();
            uiTextBox1 = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // uiAvatar2
            // 
            uiAvatar2.Anchor = AnchorStyles.Top;
            uiAvatar2.BackgroundImage = (Image)resources.GetObject("uiAvatar2.BackgroundImage");
            uiAvatar2.BackgroundImageLayout = ImageLayout.Zoom;
            uiAvatar2.FillColor = Color.Transparent;
            uiAvatar2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar2.ForeColor = Color.Transparent;
            uiAvatar2.Location = new Point(151, 33);
            uiAvatar2.MinimumSize = new Size(1, 1);
            uiAvatar2.Name = "uiAvatar2";
            uiAvatar2.Size = new Size(546, 119);
            uiAvatar2.TabIndex = 1;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiTextBox1.FillReadOnlyColor = Color.White;
            uiTextBox1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(13, 174);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MaxLength = 1;
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Multiline = true;
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ReadOnly = true;
            uiTextBox1.ShowScrollBar = true;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(860, 454);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.TagString = "";
            uiTextBox1.Text = resources.GetString("uiTextBox1.Text");
            uiTextBox1.TextAlignment = ContentAlignment.TopCenter;
            uiTextBox1.Watermark = "";
            // 
            // Page_About
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(886, 642);
            Controls.Add(uiTextBox1);
            Controls.Add(uiAvatar2);
            Name = "Page_About";
            PageIndex = 3;
            Text = "Page_About";
            Load += Page_About_Load;
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UITextBox uiTextBox1;
    }
}