using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashRevenue
{
    public class AktarmaDashRevenueOnGetMarkupMarjinResponse
    {
        public AktarmaDashRevenueInitialModel InitialModel { get; set; }
        public JsonResult Response { get; set; }
    }
}
