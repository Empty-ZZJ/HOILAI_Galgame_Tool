namespace HOILAI_Galgame_Tool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PageControl = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            TabControl = new Sunny.UI.UITabControl();
            PageControl.SuspendLayout();
            SuspendLayout();
            // 
            // PageControl
            // 
            PageControl.Alignment = TabAlignment.Left;
            PageControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PageControl.Controls.Add(tabPage1);
            PageControl.Controls.Add(tabPage2);
            PageControl.Controls.Add(tabPage3);
            PageControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            PageControl.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PageControl.Location = new Point(5, 53);
            PageControl.MenuStyle = Sunny.UI.UIMenuStyle.White;
            PageControl.Multiline = true;
            PageControl.Name = "PageControl";
            PageControl.SelectedIndex = 0;
            PageControl.Size = new Size(198, 642);
            PageControl.SizeMode = TabSizeMode.Fixed;
            PageControl.TabBackColor = Color.FromArgb(240, 240, 240);
            PageControl.TabIndex = 0;
            PageControl.TabSelectedColor = Color.FromArgb(250, 250, 250);
            PageControl.TabUnSelectedForeColor = Color.FromArgb(48, 48, 48);
            PageControl.Selecting += PageControl_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(0, 642);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "面板";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(0, 642);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "设置";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(0, 642);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "关于";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabControl.FillColor = Color.White;
            TabControl.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TabControl.ItemSize = new Size(0, 1);
            TabControl.Location = new Point(209, 53);
            TabControl.MainPage = "";
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(886, 642);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.Style = Sunny.UI.UIStyle.Custom;
            TabControl.TabIndex = 0;
            TabControl.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            TabControl.TabVisible = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1100, 700);
            Controls.Add(TabControl);
            Controls.Add(PageControl);
            Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsForbidAltF4 = true;
            MinimumSize = new Size(1100, 700);
            Name = "MainForm";
            Padding = new Padding(2, 50, 2, 2);
            ShowDragStretch = true;
            ShowTitleIcon = true;
            Text = "花濑Galgame工具";
            TitleFont = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 1479, 831);
            Load += MainForm_Load;
            PageControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu PageControl;
        private Sunny.UI.UITabControl TabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
