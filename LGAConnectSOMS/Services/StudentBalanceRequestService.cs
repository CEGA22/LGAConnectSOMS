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
    public class StudentBalanceRequestService
    {
        public async Task<bool> CreateStudentBalanceRequest(StudentBalanceRequest request)
        {
            var apiGateway = new StudentBalanceGateway();
            var content = await apiGateway.CreateStudentBalanceRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
