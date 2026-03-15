using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.CashFlow;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.CashFlow
{
    public class MizanCashFlowOnGetChartRasyoResponse
    {
        public JsonResult Response  { get; set; }
        public MizanCashFlowRequestInitialModel InitialModel { get; set; }
    }
}
