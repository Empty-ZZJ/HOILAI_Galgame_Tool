using Sunny.UI;

namespace HOILAI_Galgame_Tool.Pages
{
    public partial class Page_Trans : UIForm
    {
        public Page_Trans ()
        {
            InitializeComponent();
        }

        private void Page_Trans_Load (object sender, EventArgs e)
        {
            this.Height = Page_Index.NowWinInfo.height;
            Trans_List.Items.Clear();
            timer_Kill.Start();
        }

        private void timer_Kill_Tick (object sender, EventArgs e)
        {
            if (!Page_Index.IsRunning)
            {
                this.Close();
            }
        }
    }
}
