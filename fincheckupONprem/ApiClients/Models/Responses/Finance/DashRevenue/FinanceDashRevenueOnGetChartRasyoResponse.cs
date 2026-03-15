using fincheckup.ApiClients.Models.Requests.Finance.DashRevenue;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRevenue
{
    public class FinanceDashRevenueOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public FinanceDashRevenueRequestInitialModel InitialModel { get; set; }
    }
}
