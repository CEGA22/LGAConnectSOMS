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
    public class TransactionHistoryGateway
    {
        static string BaseUrl = "http://cega07-001-site1.gtempurl.com/api/lga/student";
    
        public async Task<string> CreateTransactionHistory(TransactionHistory request)
        {
            string url = $"{BaseUrl}/transactionHistory";
            return await WebMethods.MakePostRequest(url, request);
        }

        public async Task<IEnumerable<TransactionHistory>> GetTransactionHistory()
        {
            try
            {
                string url = BaseUrl + "/transactionHistory_get_all";
                var content = await WebMethods.MakeGetRequest(url);
                var result = JsonConvert.DeserializeObject<IEnumerable<TransactionHistory>>(content);
                return result;
            }
            catch
            {
                return Enumerable.Empty<TransactionHistory>();
            }
        }
    }
}
