using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashRevenueKon;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashRevenueKon
{
    public class DashRevenueKonOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public DashRevenueKonInitialModel InitialModel { get; set; }

    }
}
