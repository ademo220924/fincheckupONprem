using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public DashBilancoKonInitialModel InitialModel { get; set; }
    }
}
