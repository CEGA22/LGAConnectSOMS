using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SectionsHandled
    {
        public int ID { get; set; }
        public int TeacherId { get; set; }
        public string FacultyName { get; set; }
        public int GradeLevelID { get; set; }
        public string GradeLevel { get; set; }
        public string SectionName { get; set; }

        public string DisplayText 
        {
            get => $"{GradeLevel} - {SectionName}";
        }
    }
}
