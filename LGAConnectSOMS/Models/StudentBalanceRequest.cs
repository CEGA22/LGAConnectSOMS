using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class StudentBalanceRequest
    {
        public int StudentID { get; set; }

        public int Total { get; set; }

        public int Balance { get; set; }

        public int PaymentMode { get; set; }

        public int SchoolYear { get; set; }
    }
}
