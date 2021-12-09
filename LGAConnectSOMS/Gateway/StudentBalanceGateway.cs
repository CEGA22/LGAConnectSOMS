using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class StudentBalanceGateway
    {
        static string BaseUrl = "http://ceejaygabrang-001-site1.itempurl.com/api/lga/studentBalance";

        public async Task<IEnumerable<StudentBalance>> GetStudentBalance()
        {
            try
            {
                string url = $"{BaseUrl}/get_all"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentBalance>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<StudentBalance>();
            }
        }

        public async Task<string> CreateStudentBalanceRequest(StudentBalanceRequest request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }
    }
}
