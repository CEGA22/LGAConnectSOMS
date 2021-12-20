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
    public class FacultySubjectsGateway
    {
        static string BaseUrl = "http://ceejaygabrang-001-site1.itempurl.com/api/lga/facultySubjects";

        public async Task<IEnumerable<FacultySubjects>> GetFacultySubjects(int ID)
        {
            try
            {
                string url = $"{BaseUrl}/get_all/{ID}"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<FacultySubjects>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<FacultySubjects>();
            }
        }
    }
}
