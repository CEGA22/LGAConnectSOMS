using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class FinalGradePerSubject
    {
        public string SubjectName { get; set; }

        public string FacultyName { get; set; }

        public double average { get; set; }

        public double finalgrade { get; set; }

        public DateTime datemodified { get; set; }
    }
}
