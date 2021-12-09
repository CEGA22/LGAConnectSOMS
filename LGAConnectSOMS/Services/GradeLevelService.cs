using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class GradeLevelService
    {
        public async Task<IEnumerable<GradeLevel>> GetGradeLevel()
        {
            var apiGateway = new GradeLevelGateway();
            var content = await apiGateway.GetGradeLevel();
            return content;
        }
    }
}
