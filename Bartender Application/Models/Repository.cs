using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApplication.Models
{
    public class Repository
    {
        private static List<OrderNowData> responses = new List<OrderNowData>();
        public static IEnumerable<OrderNowData> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(OrderNowData response)
        {
            responses.Add(response);
        }
    }
}
