using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtNeo
{
    public class MizanFinanceHrtNeoOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanFinanceHrtNeoRequestInitialModel InitialModel { get; set; }
    }
}
