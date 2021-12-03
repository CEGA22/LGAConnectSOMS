using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class StudentRequest
    {
        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string StudentNumber { get; set; }

        public string Password { get; set; }

        public Int64 MobileNumber { get; set; }

        public string Gender { get; set; }

        public int GradeLevelId { get; set; }

        public int SchoolYearStart { get; set; }

        public int SchoolYearEnd { get; set; }
    }
}
