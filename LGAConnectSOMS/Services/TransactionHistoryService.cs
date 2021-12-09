using LGAConnectSOMS.Gateway;
using LGAConnectSOMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGAConnectSOMS.Services
{
    public class TransactionHistoryService
    {
        public async Task<bool> CreateStudentRequest(TransactionHistory request)
        {
            var apiGateway = new TransactionHistoryGateway();
            var content = await apiGateway.CreateTransactionHistory(request);
            return JsonConvert.DeserializeObject<bool>(content);
        }

        public async Task<IEnumerable<TransactionHistory>> GetTransactionHistory()
        {
            var apiGateway = new TransactionHistoryGateway();
            var content = await apiGateway.GetTransactionHistory();
            return content;
        }
    }
}
