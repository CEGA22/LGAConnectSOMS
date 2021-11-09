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

        public async Task<StudentAccount> GetStudentAccountById(int id)
        {
            var apiGateway = new StudentAccountGateway();
            var content = await apiGateway.GetStudentAccountById(id);
            return content;
        }
    }
}
