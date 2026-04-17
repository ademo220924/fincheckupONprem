using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanDashRevenueRequestInitialMopdel InitialModel { get; set; }
    }
}
