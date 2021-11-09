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
    public class LoginService
    {
        public async Task<LoginResult> AccountLogin(LoginRequest request) 
        {
            var apiGateway = new LoginGateway();
            var content = await apiGateway.AccountLogin(request);
            return JsonConvert.DeserializeObject<LoginResult>(content);
        }
    }
}
