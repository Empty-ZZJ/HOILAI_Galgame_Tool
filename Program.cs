
using HOILAI_Galgame_Tool.SDK;

namespace HOILAI_Galgame_Tool
{
    internal static class Program
    {
        public static InIOperated Config = new("./config.ini");
        [STAThread]
        private static void Main ()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}