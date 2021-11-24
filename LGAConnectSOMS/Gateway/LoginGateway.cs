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
        static string BaseUrl = "http://ceejaygabrang-001-site1.itempurl.com/api/lga/account";

        public async Task<string> AccountLogin(LoginRequest request)
        {
            string url =$"{BaseUrl}/login";
            return await WebMethods.MakePostRequest(url, request);
        }

    }
}
