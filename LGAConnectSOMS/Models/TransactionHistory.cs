﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class TransactionHistory
    {
        public int Transactionid { get; set; }

        public string ReferenceNumber { get; set; }

        public string StudentNumber { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string Firstname { get; set; }
     
        public int Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime DateRecorded { get; set; }

        public int Studentid { get; set; }

        public string Note { get; set; }

        public int Balance { get; set; }
    }
}
