using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Konsol.DashRevenueKon
{
    public class MizanDashRevenueKonOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashRevenueKonRequestInitialModel InitialModel { get; set; }
    }
}
