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
    public class FacultyGateway
    {
        static string BaseUrl = "http://cegagabrang-001-site1.btempurl.com/api/lga";

        public async Task<IEnumerable<FacultySubjects>> GetFacultySubjects(int ID)
        {
            try
            {
                string url = $"{BaseUrl}/facultySubjects/get_all/{ID}"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<FacultySubjects>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<FacultySubjects>();
            }
        }

        public async Task<IEnumerable<SectionsHandled>> GetSectionsHandled(int facultyId)
        {
            try
            {
                string url = $"{BaseUrl}/sectionsHandled/get_all/{facultyId}"; ;

                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SectionsHandled>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SectionsHandled>();
            }
        }

        public async Task<bool> SaveSectionsHandled(SectionsHandledRequest request) 
        {
            string url = $"http://localhost:2195/api/lga/sectionsHandled";
            var result =  await WebMethods.MakePostRequest(url, request);
            return Convert.ToBoolean(result);
        }
    }
}
