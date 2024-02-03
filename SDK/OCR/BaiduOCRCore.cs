using Newtonsoft.Json;
using RestSharp;

namespace HOILAI_Galgame_Tool.SDK.OCR
{
    public static class BaiduOCRCore
    {
        private const string API_KEY = "Dceszg4wfDEbk0VRIdtislSp";
        private const string SECRET_KEY = "uq9SNbhTZZH1P8IGK1va0SgZQT7HOrAi";

        public static async Task<string> Main2 (string base64)
        {
            var client = new RestClient($"https://aip.baidubce.com/rest/2.0/ocr/v1/accurate_basic?access_token={GetAccessToken()}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("image", base64);
            request.AddParameter("detect_direction", "false");
            request.AddParameter("paragraph", "false");
            request.AddParameter("probability", "false");
            IRestResponse response = await client.ExecuteAsync(request);
            return response.Content;

        }

        /**
        * 获取文件base64编码
        * @param path 文件路径
        * @return base64编码信息，不带文件头
        */
        public static string GetFileContentAsBase64 (string path)
        {
            using (FileStream filestream = new FileStream(path, FileMode.Open))
            {
                byte[] arr = new byte[filestream.Length];
                filestream.Read(arr, 0, (int)filestream.Length);
                string base64 = Convert.ToBase64String(arr);
                return base64;
            }
        }


        /**
        * 使用 AK，SK 生成鉴权签名（Access Token）
        * @return 鉴权签名信息（Access Token）
        */
        public static string GetAccessToken ()
        {
            var client = new RestClient($"https://aip.baidubce.com/oauth/2.0/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", API_KEY);
            request.AddParameter("client_secret", SECRET_KEY);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var result = JsonConvert.DeserializeObject<dynamic>(response.Content);
            return result.access_token.ToString();
        }
    }
}
