using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailc
{
    public class FinanceDashCrmDetailcOnGetRequest
    {
        public FinanceDashCrmDetailcRequestInitialModel Request { get; set; }
    }

    public class FinanceDashCrmDetailcOnGetQuery
    {
        public FinanceDashCrmDetailcOnGetRequest Request { get; set; }
    }
}
