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
    public class SubjectsGateway
    {
        static string BaseUrl = "http://cega07-001-site1.gtempurl.com/api/lga/subjects";

        public async Task<IEnumerable<Subjects>> GetSubjects()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<Subjects>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<Subjects>();
            }
        }

        public async Task<IEnumerable<Subjects>> GetSubjectsByGradeLevel(int id)
        {
            try
            {
                string url = $"{BaseUrl}/get_by_grade_level_id/{id}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<Subjects>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<Subjects>();
            }
        }

        public async Task<IEnumerable<SubjectsHandled>> GetSubjectsHandled(int teacherId, int gradeLevel)
        {
            try
            {
                string url = $"{BaseUrl}/get_subjects_handled/{teacherId}/{gradeLevel}";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SubjectsHandled>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SubjectsHandled>();
            }
        }

        public async Task<IEnumerable<SubjectsHandled>> GetSubjectsHandledAll()
        {
            try
            {
                string url = $"{BaseUrl}/get_All_subjects_handled";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<SubjectsHandled>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<SubjectsHandled>();
            }
        }

        public async Task<IEnumerable<UnHandledSubjects>> GetAllUnHandledSubjectsHandled()
        {
            try
            {
                string url = $"{BaseUrl}/get_All_UnHandledsubjects";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<UnHandledSubjects>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<UnHandledSubjects>();
            }
        }

        public async Task<bool> SaveSubjectsHandled(SubjectsHandledRequest request)
        {
            string url = $"{BaseUrl}/subjectsHandled/";
            var result = await WebMethods.MakePostRequest(url, request);
            return Convert.ToBoolean(result);
        }
    }
}
