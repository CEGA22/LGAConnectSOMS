using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class ClassSchedule
    {
        public int ID { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Subject { get; set; }

        public string WeekDay { get; set; }

        public string Teacher { get; set; }
    }
}
