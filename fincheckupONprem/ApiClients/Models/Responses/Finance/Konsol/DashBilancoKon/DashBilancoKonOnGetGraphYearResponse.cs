using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetGraphYearResponse
    {
        public JsonResult Response { get; set; }
        public MizanDashBilancoKonRequestInitialModel InitialModel { get; set; }
    }
}

