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
    public class SchoolAccountRequestService
    {
        public async Task<bool> CreateSchoolAccountRequest(SchoolAccountRequest request)
        {
            var apiGateway = new SchoolAccountRequestGateway();
            var content = await apiGateway.CreateSchoolAccountRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> DeleteSchoolAccountRequest(int ID)
        {
            var apiGateway = new SchoolAccountRequestGateway();
            var content = await apiGateway.DeleteSchoolAccountRequest(ID);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> UpdateSchoolAccountRequest(SchoolAccountRequest request)
        {
            var apiGateway = new SchoolAccountRequestGateway();
            var content = await apiGateway.UpdateSchoolAccountRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
