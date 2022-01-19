using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class SchoolAccountRequestGateway
    {
        static string BaseUrl = "http://fate09-001-site1.itempurl.com/api/lga/school";

        public async Task<string> CreateSchoolAccountRequest(SchoolAccountRequest request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> DeleteSchoolAccountRequest(int ID)
        {
            string url = $"{BaseUrl}/delete_information_by_id/{ID}";
            return await WebMethods.MakePostRequest(url, ID);
        }

        public async Task<string> UpdateSchoolAccountRequest(SchoolAccountRequest request)
        {
            string url = $"{BaseUrl}/update_information_by_id";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<string> UpdateSchoolAccountPassword(SchoolAccountRequest request)
        {
            string url = $"{BaseUrl}/update_password";
            return await WebMethods.MakePostRequest(url, request);
        }




    }
}
