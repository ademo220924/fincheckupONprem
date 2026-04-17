using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashRevenueKon;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashRevenueKon
{
    public class DashRevenueKonOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public DashRevenueKonInitialModel InitialModel { get; set; }

    }
}
