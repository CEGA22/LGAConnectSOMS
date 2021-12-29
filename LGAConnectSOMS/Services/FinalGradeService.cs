using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class FinalGradeService
    {
        public async Task<IEnumerable<FinalGrade>> GetFinalGrade(int ID)
        {
            var apiGateway = new FinalGradeGateway();
            var content = await apiGateway.GetFinalGrades(ID);
            return content;
        }
    }
}
