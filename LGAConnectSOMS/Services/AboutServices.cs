using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class AboutServices
    {
        public async Task<IEnumerable<About>> GetClassAboutDetails()
        {
            var apiGateway = new AboutGateway();
            var content = await apiGateway.GetAbout();
            return content;
        }
    }
}
