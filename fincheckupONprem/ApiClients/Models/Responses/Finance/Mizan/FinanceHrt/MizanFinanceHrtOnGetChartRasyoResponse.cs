using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrt
{
    public class MizanFinanceHrtOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanFinanceHrtRequestInitialModel InitialModel { get; set; }
    }
}
