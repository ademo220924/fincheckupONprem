using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetChartRasyoResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashRevenueRequestInitialMopdel InitialModel { get; set; }
    }
}
