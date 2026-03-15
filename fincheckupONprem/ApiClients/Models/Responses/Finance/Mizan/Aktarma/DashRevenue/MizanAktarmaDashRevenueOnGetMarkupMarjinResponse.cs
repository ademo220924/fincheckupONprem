using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashRevenue
{
    public class MizanAktarmaDashRevenueOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanAktarmaDashRevenueRequestInitialModel InitialModel { get; set; }
    }
}
