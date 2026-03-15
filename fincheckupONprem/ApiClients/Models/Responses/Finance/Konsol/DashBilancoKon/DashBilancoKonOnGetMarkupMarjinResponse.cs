using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public DashBilancoKonInitialModel InitialModel { get; set; }
    }
}
