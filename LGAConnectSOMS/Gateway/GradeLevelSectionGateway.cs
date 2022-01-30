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
    public class GradeLevelSectionGateway
    {
        static string BaseUrl = "http://cega22-001-site1.ftempurl.com/api/lga/gradelevelsection";
        static string BaseUrl2 = "http://cega22-001-site1.ftempurl.com/api/lga/sectionsHandled";

        public async Task<IEnumerable<GradeLevelSection>> GetGradeLevel ()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<GradeLevelSection>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<GradeLevelSection>();
            }
        }

        public async Task<IEnumerable<SectionsHandled>> GetGradeLevel(int id)
        {
            try
            {
                string url = $"{BaseUrl2}/get_all/{id}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SectionsHandled>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SectionsHandled>();
            }
        }

        public async Task<string> CreateGradeLevelSectionRequest(GradeLevelSection request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> UpdateGradeLevelSectionRequest(GradeLevelSection request)
        {
            string url = $"{BaseUrl}/update_information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> DeleteSection(int ID)
        {
            string url = $"{BaseUrl}/delete_information/{ID}";
            return await WebMethods.MakePostRequest(url, ID);
        }
    }
}
