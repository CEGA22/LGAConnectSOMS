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
    public class ClassRecordRequestService
    {
        public async Task<bool> UpdateClassRecordRequest(ClassRecordRequest request)
        {
            var apiGateway = new ClassRecordsGateway();
            var content = await apiGateway.UpdateClassRecordRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
