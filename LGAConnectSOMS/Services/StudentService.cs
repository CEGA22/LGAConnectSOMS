using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class StudentService
    {
        public async Task<IEnumerable<StudentAccount>> GetStudentAccount()
        {
            var apiGateway = new StudentAccountGateway();
            var content = await apiGateway.GetStudentAccount();
            return content;
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountOnly()
        {
            var apiGateway = new StudentAccountGateway();
            var content = await apiGateway.GetStudentAccountOnly();
            return content;
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountById(string lastname)
        {
            var apiGateway = new StudentAccountGateway();
            var content = await apiGateway.GetStudentAccountById(lastname);
            return content;
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountPassword(string email)
        {
            var apiGateway = new StudentAccountGateway();
            var content = await apiGateway.GetStudentAccountPassword(email);
            return content;
        }

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountByGradeLevel(string gradelevel)
        //{
        //    var apiGateway = new StudentAccountGateway();
        //    var content = await apiGateway.GetStudentAccountByGradeLevel(gradelevel);
        //    return content;
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentByGradeLevelFilter()
        //{
        //    var apiGateway = new StudentAccountGateway();
        //    var content = await apiGateway.GetStudentAccountByGradeLevelFilter();
        //    return content;
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountBySection(string section)
        //{
        //    var apiGateway = new StudentAccountGateway();
        //    var content = await apiGateway.GetStudentAccountBySection(section);
        //    return content;
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentBySectionFilter()
        //{
        //    var apiGateway = new StudentAccountGateway();
        //    var content = await apiGateway.GetStudentAccountBySectionFilter();
        //    return content;
        //}
    }
}

