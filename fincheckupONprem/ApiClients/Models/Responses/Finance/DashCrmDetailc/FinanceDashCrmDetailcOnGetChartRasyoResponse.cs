using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailc;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetailc
{
    public class FinanceDashCrmDetailcOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashCrmDetailcRequestInitialModel InitialModel { get; set; }
    }
}
