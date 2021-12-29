using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class NewsAndAnnouncementsService
    {
        public async Task<IEnumerable<NewsAndAnnouncements>> GetNewsAndAnnouncements()
        {
            var apiGateway = new NewsAndAnnouncementGateway();
            var content = await apiGateway.GetNewsAndAnnouncements();
            return content;
        }

        public async Task<bool> CreateNewsAndAnnouncements(NewsAndAnnouncements request)
        {
            var apiGateway = new NewsAndAnnouncementGateway();
            var content = await apiGateway.CreateNewsAndAnnouncements(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> UpdateNewsAndAnnouncement(NewsAndAnnouncements request)
        {
            var apiGateway = new NewsAndAnnouncementGateway();
            var content = await apiGateway.UpdateNewsAndAnnouncement(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> DeleteNewsAndAnnouncement(int ID)
        {
            var apiGateway = new NewsAndAnnouncementGateway();
            var content = await apiGateway.DeleteNewsAndAnnouncement(ID);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
