using fincheckup.ApiClients.Models.Requests.Finance.DashCrm;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartRasyocResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashCrmRequestInitialModel InitialModel { get; set; }
    }
}
