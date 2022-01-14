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

        public int SchoolID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string FullName
        {
            get => $"{Firstname} {Lastname}";
        }

        public string Subject { get; set; }

        public string GradeLevelSection
        {
            get => $"{GradeLevel} - {SectionName}";
        }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
   
        public string WeekDay { get; set; }

        public string GradeLevel { get; set; }

        public string SectionName { get; set; } 
    }
}
