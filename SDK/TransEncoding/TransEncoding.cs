using System.Text.RegularExpressions;

namespace HOILAI_Galgame_Tool.SDK.TransEncoding
{
    public static class TransEncoding
    {
        public static string ConvertUnicodeToChinese (string unicodeString)
        {
            return Regex.Unescape(unicodeString);
        }
    }
}
