using System.Text.Json;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilanco
{
    public class MizanDashBilancoOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoRequestInitialModel InitialModel { get; set; }
    }
}
