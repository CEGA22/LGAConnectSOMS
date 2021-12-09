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
    public class GradeLevelRequestService
    {
        public async Task<bool> CreateGradeLevelRequest(GradeLevelRequest request)
        {
            var apiGateway = new GradeLevelRequestGateway();
            var content = await apiGateway.CreateGradeLevelRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
