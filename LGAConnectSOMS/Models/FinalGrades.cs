using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
     public class FinalGrades
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public Dictionary<string, double> FinalGradesList { get; set; }
    }
}
