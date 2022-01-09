using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Models
{
    public class SubjectsHandled
    {
        public int Id { get; set; }

        public int TeacherId { get; set; }

        public string TeacherName { get; set; }

        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public string SubjectCode { get; set; }

        public int GradeLevelId { get; set; }

        public string GradeLevel { get; set; }

        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string SectionName { get; set; }

        private string fullname;

        public string Fullname
        {
            get { return $"{Firstname} {Lastname}"; }
            set { fullname = value; }
        }

    }
}
