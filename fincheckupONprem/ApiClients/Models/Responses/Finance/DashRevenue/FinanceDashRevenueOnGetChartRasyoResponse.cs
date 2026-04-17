using fincheckup.ApiClients.Models.Requests.Finance.DashRevenue;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashRevenue
{
    public class FinanceDashRevenueOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashRevenueRequestInitialModel InitialModel { get; set; }
    }
}
