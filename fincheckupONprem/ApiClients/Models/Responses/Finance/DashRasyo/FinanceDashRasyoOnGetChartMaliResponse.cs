using fincheckup.ApiClients.Models.Requests.Finance.DashRasyo;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRasyo
{
    public class FinanceDashRasyoOnGetChartMaliResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashRasyoRequestInitialModel InitialModel { get; set; }
    }
}
