using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class StudentBalanceService
    {
        public async Task<IEnumerable<StudentBalance>> GetStudentBalance()
        {
            var apiGateway = new StudentBalanceGateway();
            var content = await apiGateway.GetStudentBalance();
            return content;
        }
    }
}
