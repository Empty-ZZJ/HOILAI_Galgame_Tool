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
            AsideList = new Sunny.UI.UIListBox();
            SuspendLayout();
            // 
            // AsideList
            // 
            AsideList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AsideList.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AsideList.HoverColor = Color.FromArgb(155, 200, 255);
            AsideList.ItemSelectForeColor = Color.White;
            AsideList.Location = new Point(0, 0);
            AsideList.Margin = new Padding(4, 5, 4, 5);
            AsideList.MinimumSize = new Size(1, 1);
            AsideList.Name = "AsideList";
            AsideList.Padding = new Padding(2);
            AsideList.ShowText = false;
            AsideList.Size = new Size(268, 830);
            AsideList.TabIndex = 0;
            AsideList.Text = "uiListBox1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 831);
            Controls.Add(AsideList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "花濑Galgame工具";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIListBox AsideList;
    }
}
