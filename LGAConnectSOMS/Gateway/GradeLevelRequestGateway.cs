using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class GradeLevelRequestGateway
    {
        static string BaseUrl = "http://cega22-001-site1.ftempurl.com/api/lga/gradelevel";

        public async Task<string> CreateGradeLevelRequest(GradeLevelRequest request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }
    }
}
