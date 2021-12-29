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
        static string BaseUrl = "http://cegagabrang-001-site1.btempurl.com/api/lga/schoolAccount";

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
    }
}
