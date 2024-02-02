using Sunny.UI;

namespace HOILAI_Galgame_Tool.Pages
{
    public partial class Page_Settings : UIPage
    {

        public Page_Settings ()
        {
            InitializeComponent();


        }

        private void Page_Settings_Load (object sender, EventArgs e)
        {

        }

        private void uiLinkLabel1_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://api.fanyi.baidu.com");

        }

        private void uiLinkLabel4_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://console.bce.baidu.com/ai/#/ai/ocr/overview/index");
        }
        private void SetChecked_翻译 (int i)
        {
            if (i.Equals(1))
            {
                Program.Config.WriteValue("API", "trans", "1");
                TextBox_id_trans.Enabled = false;
                TextBox_key_trans.Enabled = false;
                CheckBox_使用花濑提供的API_翻译.Checked = true;
                CheckBox_使用自己的API_翻译.Checked = false;
            }
            else
            {
                Program.Config.WriteValue("API", "trans", "2");
                TextBox_id_trans.Enabled = true;
                TextBox_key_trans.Enabled = true;
                CheckBox_使用花濑提供的API_翻译.Checked = !true;
                CheckBox_使用自己的API_翻译.Checked = !false;
            }

        }
        private void SetChecked_OCR (int i)
        {

            if (i.Equals(1))
            {
                Program.Config.WriteValue("API", "ocr", "1");
                TextBox_id_ocr.Enabled = false;
                TextBox_key_ocr.Enabled = false;
                CheckBox_使用花濑提供的API_OCR.Checked = true;
                CheckBox_使用自己的API_OCR.Checked = false;

            }
            else
            {
                Program.Config.WriteValue("API", "ocr", "2");
                TextBox_id_ocr.Enabled = true;
                TextBox_key_ocr.Enabled = true;
                CheckBox_使用花濑提供的API_OCR.Checked = !true;
                CheckBox_使用自己的API_OCR.Checked = !false;
            }
        }

        private void CheckBox_使用花濑提供的API_翻译_Click (object sender, EventArgs e)
        {
            SetChecked_翻译(1);
        }

        private void CheckBox_使用自己的API_翻译_Click (object sender, EventArgs e)
        {
            SetChecked_翻译(2);
        }

        private void CheckBox_使用花濑提供的API_OCR_Click (object sender, EventArgs e)
        {
            SetChecked_OCR(1);
        }

        private void CheckBox_使用自己的API_OCR_Click (object sender, EventArgs e)
        {
            SetChecked_OCR(2);
        }

        private void Page_Settings_Initialize (object sender, EventArgs e)
        {
            SetChecked_翻译(Convert.ToInt32(Program.Config.ReadValue("API", "trans", "1")));
            SetChecked_OCR(Convert.ToInt32(Program.Config.ReadValue("API", "ocr", "1")));
            if (CheckBox_使用自己的API_翻译.Checked)
            {
                TextBox_id_trans.Text = Program.Config.ReadValue("API-Trans", "id");
                TextBox_key_trans.Text = Program.Config.ReadValue("API-Trans", "key");
            }
            if (CheckBox_使用自己的API_OCR.Checked)
            {
                TextBox_id_ocr.Text = Program.Config.ReadValue("API-OCR", "id");
                TextBox_key_ocr.Text = Program.Config.ReadValue("API-OCR", "key");
            }

        }

        private void Button_Save_Click (object sender, EventArgs e)
        {
            Program.Config.WriteValue("API-Trans", "id", TextBox_id_trans.Text);
            Program.Config.WriteValue("API-Trans", "key", TextBox_key_trans.Text);
            Program.Config.WriteValue("API-OCR", "id", TextBox_id_ocr.Text);
            Program.Config.WriteValue("API-OCR", "key", TextBox_key_ocr.Text);
            UIMessageBox.Show("保存成功", false, true);
        }


    }
}
