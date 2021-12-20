using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class SubjectsService
    {
        public async Task<IEnumerable<Subjects>> GetSubjects()
        {
            var apiGateway = new SubjectsGateway();
            var content = await apiGateway.GetSubjects();
            return content;
        }
    }
}
