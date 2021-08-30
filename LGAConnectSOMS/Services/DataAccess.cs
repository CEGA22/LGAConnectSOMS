using Dapper;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS.Services
{
    public class DataAccess
    {
        //ReadandDisplayStudentsData
        public List<Students> GetStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
            {

                return connection.Query<Students>($"SELECT Students.Lastname, Students.Firstname, Students.Middlename, Students.Gender, GradeLevel.Grade_Level,GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID").ToList();
            }
        }

        ////ReadandDisplayStudentsDataByLastname
        public List<Students> GetStudentsByLastname(string Lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
            {
                return connection.Query<Students>($"SELECT Students.Lastname, Students.Firstname, Students.Middlename, Students.GradeLevel, GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID  WHERE Students.Lastname = '{Lastname}'").ToList();
            }
        }

        //public void AddStudent(string lastname, string firstname, string middlename, string gender, int gradeLevel)
        //{

        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
        //    {
        //        List<Students> addstudents = new List<Students>();
        //        addstudents.Add(new Students { Lastname = lastname, Firstname = firstname, Middlename = middlename, Gender = gender, GradeLevel = gradeLevel });
        //        connection.Execute($"INSERT INTO Students VALUES(@Lastname, @Firstname, @Middlename, @Gender, @GradeLevel)", addstudents);
        //        MessageBox.Show("Added Student Successfully!");
        //    }



        //}
    }
}
