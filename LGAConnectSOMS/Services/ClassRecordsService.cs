using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class ClassRecordsService
    {
        public async Task<IEnumerable<ClassRecords>> GetClassRecrodsDetails(int ID)
        {
            var apiGateway = new ClassRecordsGateway();
            var content = await apiGateway.GetClassRecords(ID);
            return content;
        }
    }
}
