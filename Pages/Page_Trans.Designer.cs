namespace HOILAI_Galgame_Tool.Pages
{
    partial class Page_Trans
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
            components = new System.ComponentModel.Container();
            Trans_List = new Sunny.UI.UIListBox();
            timer_Kill = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Trans_List
            // 
            Trans_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Trans_List.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Trans_List.HoverColor = Color.FromArgb(155, 200, 255);
            Trans_List.Items.AddRange(new object[] { "你哈1", "是这样的", "但是也" });
            Trans_List.ItemSelectForeColor = Color.White;
            Trans_List.Location = new Point(4, 55);
            Trans_List.Margin = new Padding(4, 5, 4, 5);
            Trans_List.MinimumSize = new Size(1, 1);
            Trans_List.Name = "Trans_List";
            Trans_List.Padding = new Padding(2);
            Trans_List.ShowText = false;
            Trans_List.Size = new Size(524, 813);
            Trans_List.TabIndex = 0;
            Trans_List.Text = "Trans_List";
            // 
            // timer_Kill
            // 
            timer_Kill.Tick += timer_Kill_Tick;
            // 
            // Page_Trans
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(532, 873);
            Controls.Add(Trans_List);
            Name = "Page_Trans";
            Padding = new Padding(0, 50, 0, 0);
            Text = "翻译结果";
            TitleFont = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            Load += Page_Trans_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIListBox Trans_List;
        private System.Windows.Forms.Timer timer_Kill;
    }
}