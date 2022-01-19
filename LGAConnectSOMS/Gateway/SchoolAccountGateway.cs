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
    public class SchoolAccountGateway
    {
        static string BaseUrl = "http://fate09-001-site1.itempurl.com/api/lga/schoolAccount";

        public async Task<IEnumerable<SchoolAccount>> GetSchoolAccountDetails()
        {
            try
            {
                string url = $"{BaseUrl}/get_all"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SchoolAccount>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SchoolAccount>();
            }
        }

        public async Task<IEnumerable<SchoolAccount>> GetSchoolAccountOnly()
        {
            try
            {
                string url = BaseUrl + "/get_accountOnly";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SchoolAccount>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SchoolAccount>();
            }
        }

        public async Task<IEnumerable<SchoolAccount>> GetSchoolAccountPassword(string email)
        {
            try
            {
                string url = $"{BaseUrl}/get_password/{email}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SchoolAccount>>(content);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
