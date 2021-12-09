using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class StudentBalance
    {
        public int id { get; set; }

        public string StudentNumber { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public int Total { get; set; }

        public int Balance { get; set; }

        public string PaymentMode { get; set; }

        public int DownPayment { get; set; }

        public string Description { get; set; }
    }
}
