﻿using LGAConnectSOMS.Helpers;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Gateway
{
    public class GradeLevelGateway
    {
        static string BaseUrl = "http://cega22-001-site1.ftempurl.com/api/lga/gradelevel";

        public async Task<IEnumerable<GradeLevel>> GetGradeLevel()
        {
            try
            {
                string url = BaseUrl + "/get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<GradeLevel>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<GradeLevel>();
            }
        }
    }
}
