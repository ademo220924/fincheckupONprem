using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Konsol.DashBilancoKon
{
    public class MizanDashBilancoKonOnGetGraphYearResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoKonRequestInitialModel InitialModel { get; set; }
    }
}

