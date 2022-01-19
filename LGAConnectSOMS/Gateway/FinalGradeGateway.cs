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
    public class FinalGradeGateway
    {
        static string BaseUrl = "http://fate09-001-site1.itempurl.com/api/lga/finalgrade";

        public async Task<IEnumerable<FinalGrade>> GetFinalGrades(int ID)
        {
            try
            {
                string url = $"{BaseUrl}/get_all/{ID}"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<FinalGrade>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<FinalGrade>();
            }
        }
    }
}
