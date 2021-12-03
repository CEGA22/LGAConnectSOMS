using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class StudentRequestGateway
    {
       
        static string BaseUrl = "http://ceejaygabrang-001-site1.itempurl.com/api/lga/student";

        public async Task<string> CreateStudentRequest(StudentRequest request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }
    }
}
