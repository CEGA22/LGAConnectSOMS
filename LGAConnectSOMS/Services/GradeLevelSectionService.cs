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
    public class GradeLevelSectionService
    {
        public async Task<IEnumerable<GradeLevelSection>> GetGradeLevel ()
        {
            var apiGateway = new GradeLevelSectionGateway();
            var content = await apiGateway.GetGradeLevel();
            return content;
        }

        public async Task<bool> CreateGradeLevelSectinRequest(GradeLevelSection request)
        {
            var apiGateway = new  GradeLevelSectionGateway();
            var content = await apiGateway.CreateGradeLevelSectinRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
