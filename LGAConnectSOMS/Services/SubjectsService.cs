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

        public async Task<IEnumerable<Subjects>> GetSubjectsByGradeLevel(int id)
        {
            var apiGateway = new SubjectsGateway();
            var content = await apiGateway.GetSubjectsByGradeLevel(id);
            return content;
        }

        public async Task<IEnumerable<SubjectsHandled>> GetSubjectsHandled(int id)
        {
            var apiGateway = new SubjectsGateway();
            var content = await apiGateway.GetSubjectsHandled(id);
            return content;
        }
    }
}
