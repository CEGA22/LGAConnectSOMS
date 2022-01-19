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
    public class NewsAndAnnouncementGateway
    {
        static string BaseUrl = "http://fate09-001-site1.itempurl.com/api/lga/newsAndAnnouncements";

        public async Task<IEnumerable<NewsAndAnnouncements>> GetNewsAndAnnouncements()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<NewsAndAnnouncements>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<NewsAndAnnouncements>();
            }
        }

        public async Task<string> CreateNewsAndAnnouncements(NewsAndAnnouncements request)
        {
            string url = $"{BaseUrl}/create_information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> UpdateNewsAndAnnouncement(NewsAndAnnouncements request)
        {
            string url = $"{BaseUrl}/update_information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> DeleteNewsAndAnnouncement(int ID)
        {
            string url = $"{BaseUrl}/delete_information/{ID}";
            return await WebMethods.MakePostRequest(url, ID);
        }      
    }
}
