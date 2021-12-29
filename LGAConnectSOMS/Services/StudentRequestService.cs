using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class StudentRequestService
    {

        public async Task<bool> CreateStudentRequest(StudentRequest request)
        {
            var apiGateway = new StudentRequestGateway();
            var content = await apiGateway.CreateStudentRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> UpdateStudentRequest(StudentRequest request)
        {
            var apiGateway = new StudentRequestGateway();
            var content = await apiGateway.UpdateStudentRequest(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<bool> DeleteStudentRequest(int ID)
        {
            var apiGateway = new StudentRequestGateway();
            var content = await apiGateway.DeleteStudentRequest(ID);
            return JsonConvert.DeserializeObject<bool>(content);
        }
    }
}
