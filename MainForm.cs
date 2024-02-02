using HOILAI_Galgame_Tool.Pages;
using HOILAI_Galgame_Tool.SDK.BaiduTranslate;
using HOILAI_Galgame_Tool.SDK.Model;
using HOILAI_Galgame_Tool.SDK.TransEncoding;
using Newtonsoft.Json;
using Sunny.UI;

namespace HOILAI_Galgame_Tool
{
    public partial class MainForm : UIForm
    {
        public MainForm ()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError(ex.Message);
            }

        }

        private async void MainForm_Load (object sender, EventArgs e)
        {
            InitUI();
            return;
            foreach (var _item in JsonConvert.DeserializeObject<Model_BaiduTransJson>(TransEncoding.ConvertUnicodeToChinese(await BaiduTransCore.GetTranslate("the original"))).trans_result)
            {
                UIMessageBox.Show(_item.dst);
            }


        }
        private void InitUI ()
        {
            //Form
            AddPage(new Page_Index());
            AddPage(new Page_Settings());
            AddPage(new Page_About());
        }

        private void PageControl_Selecting (object sender, TabControlCancelEventArgs e)
        {
            SelectPage(PageControl.SelectedIndex + 1);
        }
    }
}
