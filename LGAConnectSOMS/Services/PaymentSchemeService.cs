using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class PaymentSchemeService
    {
        public async Task<IEnumerable<PaymentScheme>> GetPaymentScheme()
        {
            var apiGateway = new PaymentSchemeGateway();
            var content = await apiGateway.GetPaymentScheme();
            return content;
        }
    }
}
