using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class StudentAccountGateway
    {
        static string BaseUrl = "http://localhost:2195/api/lga/student";

        public async Task<IEnumerable<StudentAccount>> GetStudentAccount()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
                return result;
            }
            catch 
            {
                return Enumerable.Empty<StudentAccount>();
            }
        }

        public async Task<StudentAccount> GetStudentAccountById(int id)
        {
            try
            {
                string url = $"{BaseUrl}/get_by_id/{id}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<StudentAccount>(content);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
