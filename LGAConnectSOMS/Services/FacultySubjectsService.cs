using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class FacultySubjectsService
    {
        public async Task<IEnumerable<FacultySubjects>> GetFacultySubjects(int ID)
        {
            var apiGateway = new FacultySubjectsGateway();
            var content = await apiGateway.GetFacultySubjects(ID);
            return content;
        }
    }
}
