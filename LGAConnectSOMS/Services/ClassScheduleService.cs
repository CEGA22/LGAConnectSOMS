using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class ClassScheduleService
    {
        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleDetails()
        {
            var apiGateway = new ClassScheduleGateway();
            var content = await apiGateway.GetClassSchedule();
            return content;
        }

        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleByWeekDayDetails(string weekday)
        {
            var apiGateway = new ClassScheduleGateway();
            var content = await apiGateway.GetClassScheduleByWeekDay(weekday);
            return content;
        }

        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleWeekFacultyDetails(int ID, string weekday)
        {
            var apiGateway = new ClassScheduleGateway();
            var content = await apiGateway.GetClassScheduleWeekFaculty(ID, weekday);
            return content;
        }

        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleByWeekDayDetailsFaculty(string weekday)
        {
            var apiGateway = new ClassScheduleGateway();
            var content = await apiGateway.GetClassScheduleByWeekDayFaculty(weekday);
            return content;
        }

        public async Task<IEnumerable<ClassSchedule>> GetClassScheduleFacultyDetails(int ID)
        {
            var apiGateway = new ClassScheduleGateway();
            var content = await apiGateway.GetClassScheduleFaculty(ID);
            return content;
        }
    }
}
