using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SchoolAccount
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Lastname")]
        public string lastName { get; set; }

        [DisplayName("Middlename")]
        public string middlename { get; set; }

        [DisplayName("Firstname")]
        public string firstname { get; set; }

        [DisplayName("School Number")]
        public string schoolNumber { get; set; }

        [DisplayName("Password")]
        public string password { get; set; }

        [DisplayName("User Profile")]
        public byte[] TeacherProfile { get; set; }

        [DisplayName("Mobile Number")]
        public string mobileNumber { get; set; }

        [DisplayName("Gender")]
        public string gender { get; set; }

        [DisplayName("Position")]
        public int isAdmin { get; set; }

        private string fullname;

        public string Fullname
        {
            get { return $"{firstname} {lastName}"; }
            set { fullname = value; }
        }

    }
}
