
namespace HOILAI_Galgame_Tool
{
    internal static class Program
    {
        [STAThread]
        private static void Main ()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }
    }
}