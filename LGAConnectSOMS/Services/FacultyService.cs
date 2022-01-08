using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class FacultyService
    {
        public async Task<IEnumerable<FacultySubjects>> GetFacultySubjects(int ID)
        {
            var apiGateway = new FacultyGateway();
            var content = await apiGateway.GetFacultySubjects(ID);
            return content;
        }

        public async Task<IEnumerable<SectionsHandled>> GetSectionsHandled(int facultyId)
        {
            var apiGateway = new FacultyGateway();
            var content = await apiGateway.GetSectionsHandled(facultyId);
            return content;
        }

        public async Task<bool> SaveSectionsHandled(SectionsHandledRequest request)
        {
            var apiGateway = new FacultyGateway();
            return await apiGateway.SaveSectionsHandled(request);
        }
    }
}
