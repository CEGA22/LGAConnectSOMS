using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class StudentAccountGateway
    {
        static string BaseUrl = "http://cega22-001-site1.ftempurl.com/api/lga/student";

        public async Task<IEnumerable<StudentAccount>> GetStudentAccount()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
                return result;
            }
            catch 
            {
                return Enumerable.Empty<StudentAccount>();
            }
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountOnly()
        {
            try
            {
                string url = BaseUrl + "/get_accountOnly";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<StudentAccount>();
            }
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountById(string lastname)
        {
            try
            {
                string url = $"{BaseUrl}/get_by_id/{lastname}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<StudentAccount>> GetStudentAccountPassword(string email)
        {
            try
            {
                string url = $"{BaseUrl}/get_password/{email}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
                return result;
            }
            catch
            {
                return null;
            }
        }

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountByGradeLevel(string gradelevel)
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_gradelevel/{gradelevel}";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountByGradeLevelFilter()
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_gradelevelFilter";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountBySection(string section)
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_section/{section}";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public async Task<IEnumerable<StudentAccount>> GetStudentAccountBySectionFilter()
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_sectionFilter";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<StudentAccount>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
    }
}
