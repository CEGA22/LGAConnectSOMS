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
    //public class DataAccess
    //{
    //    //ReadandDisplayStudentsData
    //    public List<Students> GetStudents()
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {

    //            return connection.Query<Students>($"SELECT Students.ID, Students.Lastname, Students.Firstname, Students.Middlename, Students.Gender, GradeLevel.Grade_Level,GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID").ToList();
    //        }
    //    }

    //    public List<GradeLevelModel> GetStudentsByGradeLevel()
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            return connection.Query<GradeLevelModel>($"SELECT Grade_Level FROM GradeLevel").ToList();
    //        }
    //    }

    //    public List<GradeLevelModel> GetStudentsBySection()
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            return connection.Query<GradeLevelModel>($"SELECT Section FROM GradeLevel").ToList();
    //        }
    //    }

    //    ////SearchStudentsDataByLastname
    //    public List<Students> GetStudentsByLastname(string Lastname)
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            return connection.Query<Students>($"SELECT Students.ID, Students.Lastname, Students.Firstname, Students.Middlename, Students.Gender, GradeLevel.Grade_Level, GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID  WHERE Students.Lastname = '{Lastname}'").ToList();
    //        }
    //    }

    //    //FilterbyGradeandSection
    //    public List<Students> FilterByGrade(string gradelevel)
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            return connection.Query<Students>($"SELECT Students.Lastname, Students.Firstname, Students.Middlename, Students.Gender, GradeLevel.Grade_Level, GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID  WHERE GradeLevel.Grade_Level = '{gradelevel}'").ToList();
    //        }
    //    }

    //    public List<Students> FilterBySection(string section)
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            return connection.Query<Students>($"SELECT Students.Lastname, Students.Firstname, Students.Middlename, Students.Gender, GradeLevel.Grade_Level, GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID  WHERE GradeLevel.Section = '{section}'").ToList();
    //        }
    //    }

    //    //AddNewStudent
    //    public void AddStudent(string lastname, string firstname, string middlename, string gender, int gradeLevel)
    //    {
    //        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
    //        {
    //            List<StudentDetailsModel> addstudents = new List<StudentDetailsModel>();
    //            addstudents.Add(new StudentDetailsModel { Lastname = lastname, Firstname = firstname, Middlename = middlename, Gender = gender, GradeLevel = gradeLevel });
    //            connection.Execute($"INSERT INTO Students VALUES(@Lastname, @Firstname, @Middlename, @Gender, @GradeLevel)", addstudents);
    //            MessageBox.Show("Added New Student Successfully! \n Check the newly added Student in List of Students tab", "New Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        }
    //    }
    //}
}
