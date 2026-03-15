using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetaila;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetaila
{
    public class FinanceDashCrmDetailaOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashCrmDetailaRequestInitialModel InitialModel { get; set; }
    }
}
