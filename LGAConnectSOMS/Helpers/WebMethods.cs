using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Helpers
{
    public class WebMethods
    {

        public static async Task<string> MakeGetRequest(string url)
        {

            var strReturn = string.Empty;

            try
            {
                var request = WebRequest.Create(url);
                HttpWebResponse response = await request.GetResponseAsync() as HttpWebResponse;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        strReturn = reader.ReadToEnd();

                        if (string.IsNullOrWhiteSpace(strReturn))
                        {
                            strReturn = response.StatusCode + "Response contained an empty body ...";
                        }

                        return strReturn;
                    }
                }

                else
                {
                    return "error";
                }
            }

            catch
            {
                return "error";
            }
        }

        public static async Task<string> MakePostRequest(string url, object content)
        {
            try
            {
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(content);
                HttpContent httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await httpClient.PostAsync(url, httpContent);
                return result.Content.ReadAsStringAsync().Result;
            }

            catch (System.Exception ex)
            {

                var x = ex.Message;
                return "error";
            }



        }

    }
}
