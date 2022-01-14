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
       
        static string BaseUrl = "http://cega07-001-site1.gtempurl.com/api/lga/student";

        public async Task<string> CreateStudentRequest(StudentRequest request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> UpdateStudentRequest(StudentRequest request)
        {
            string url = $"{BaseUrl}/update_information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> DeleteStudentRequest(int ID)
        {
            string url = $"{BaseUrl}/delete_information/{ID}";
            return await WebMethods.MakePostRequest(url, ID);
        }
    }
}
