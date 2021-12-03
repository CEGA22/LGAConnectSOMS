using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
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
    }
}
