using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class PaymentScheme
    {
        public int SchemeID { get; set; }

        public string PaymentMode { get; set; }

        public string Description { get; set; }

        public int DownPayment { get; set; }

        public int Total { get; set; }
    }
}
