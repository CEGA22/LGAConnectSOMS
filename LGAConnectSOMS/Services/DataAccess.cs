using Dapper;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class DataAccess
    {
        public List<Students> GetStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("LGAConnectDB")))
            {
                return connection.Query<Students>($"SELECT Students.Lastname, Students.Firstname, Students.Middlename, GradeLevel.Grade_Level, GradeLevel.Section FROM Students JOIN GradeLevel ON Students.GradeLevel = GradeLevel.ID").ToList();
                

            }
        }
    }
}
