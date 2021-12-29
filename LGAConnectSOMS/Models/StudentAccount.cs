using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class StudentAccount
    {       
        public int ID { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public string ParentsName { get; set; }

        public string StudentNumber { get; set; }

        public string Password { get; set; }

        public string mobileNumber { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        [DisplayName("Grade Level")]
        public string Grade_Level { get; set; }

        [DisplayName("Section Name")]
        public string SectionName { get; set; }

        public byte[] StudentProfile { get; set; }

        public string SchoolYearStart { get; set; }

        public string SchoolYearEnd { get; set; }
    }
}
