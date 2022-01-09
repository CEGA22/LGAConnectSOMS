using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SubjectsHandledRequest
    {
        public IEnumerable<SubjectsHandled> SubjectsHandled { get; set; }

        public int TeacherID { get; set; }

        public int GradeLevelID { get; set; }
    }
}
