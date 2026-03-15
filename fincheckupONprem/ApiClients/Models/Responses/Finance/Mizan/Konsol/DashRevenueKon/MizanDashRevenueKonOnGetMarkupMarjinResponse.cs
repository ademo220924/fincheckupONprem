using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Konsol.DashRevenueKon
{
    public class MizanDashRevenueKonOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashRevenueKonRequestInitialModel InitialModel { get; set; }
    }
}
