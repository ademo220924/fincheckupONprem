using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetail
{
    public class FinanceDashCrmDetailOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashCrmDetailRequestInitialModel Request { get; set; }
    }
}
