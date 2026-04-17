using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueMlt;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoRevenueMlt
{
    public class MizanDashBilancoRevenueMltOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashBilancoRevenueMltRequestInitialModel InitialModel { get; set; }
    }
}
