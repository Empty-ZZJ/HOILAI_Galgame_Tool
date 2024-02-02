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
            SuspendLayout();
            // 
            // Page_Index
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(886, 642);
            Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Page_Index";
            PageIndex = 1;
            Text = "Page_Index";
            Load += Page_Index_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}