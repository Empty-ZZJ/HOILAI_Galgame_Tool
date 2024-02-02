namespace HOILAI_Galgame_Tool.SDK.Model
{
    public class Model_BaiduTransJson
    {
        public required string @from { get; set; }
        public required string to { get; set; }
        public required List<Model_Trans_resultItem> trans_result { get; set; }
    }
    public class Model_Trans_resultItem
    {
        /// <summary>
        /// 
        /// </summary>
        public required string src { get; set; }
        /// <summary>
        /// 原件
        /// </summary>
        public required string dst { get; set; }
    }



}
