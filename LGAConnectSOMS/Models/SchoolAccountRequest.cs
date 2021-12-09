using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SchoolAccountRequest
    {
        public int id { get; set; }

        public string LastName { get; set; }

        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string SchoolNumber { get; set; }

        public string Password { get; set; }

        public byte[] TeacherProfile { get; set; }

        public string MobileNumber { get; set; }

        public string Gender { get; set; }

        public int IsAdmin { get; set; }
    }
}
