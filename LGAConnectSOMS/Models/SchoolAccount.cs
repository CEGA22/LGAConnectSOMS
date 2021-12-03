using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SchoolAccount
    {
        public int id { get; set; }

        public string lastName { get; set; }

        public string middlename { get; set; }

        public string firstname { get; set; }

        public string schoolNumber { get; set; }

        public string password { get; set; }

        public Int64 mobileNumber { get; set; }

        public string gender { get; set; }

        public int isAdmin { get; set; }
    }
}
