using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetGraphYearResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoKonRequestInitialModel InitialModel { get; set; }
    }
}

