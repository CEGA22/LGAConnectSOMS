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
    public class ClassScheduleGateway
    {
        static string BaseUrl = "http://cegagabrang-001-site1.btempurl.com/api/lga/classSchedule";

        public async Task<IEnumerable<ClassSchedule>> GetClassSchedule()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<ClassSchedule>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<ClassSchedule>();
            }
        }

        //public async Task<IEnumerable<ClassSchedule>> GetClassScheduleWeekFaculty(int ID, string weekday)
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_Week_Faculty/{ID}/{weekday}";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<ClassSchedule>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return Enumerable.Empty<ClassSchedule>();
        //    }
        //}

        //public async Task<IEnumerable<ClassSchedule>> GetClassScheduleByWeekDayFaculty(string weekday)
        //{
        //    try
        //    {
        //        string url = $"{BaseUrl}/get_by_Weekday_Faculty/{weekday}";
        //        var content = await WebMethods.MakeGetRequest(url);
        //        var result = JsonConvert.DeserializeObject<IEnumerable<ClassSchedule>>(content);
        //        return result;
        //    }
        //    catch
        //    {
        //        return Enumerable.Empty<ClassSchedule>();
        //    }
        //}

        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleFaculty(int ID)
        {
            try
            {
                string url = $"{BaseUrl}/get_all_faculty/{ID}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<ClassSchedule>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<ClassSchedule>();
            }
        }

        public async Task<string> CreateClassScheduleRequest(IEnumerable<ClassScheduleRequest> request)
        {
            string url = $"{BaseUrl}/information";
            return await WebMethods.MakePostRequest(url, request);
        }
    }
}
