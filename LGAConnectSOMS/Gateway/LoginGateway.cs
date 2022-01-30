using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class LoginGateway
    {
        static string BaseUrl = "http://cega22-001-site1.ftempurl.com/api/lga/account";

        public async Task<string> AccountLogin(LoginRequest request)
        {
            string url =$"{BaseUrl}/login";
            return await WebMethods.MakePostRequest(url, request);
        }

    }
}
