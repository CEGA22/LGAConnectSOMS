using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }

        public int ID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Fullname { get; set; }

        public int IsAdmin { get; set; }

        public int IsFaculty { get; set; }

        public byte[] TeacherProfile { get; set; }
    }
}
