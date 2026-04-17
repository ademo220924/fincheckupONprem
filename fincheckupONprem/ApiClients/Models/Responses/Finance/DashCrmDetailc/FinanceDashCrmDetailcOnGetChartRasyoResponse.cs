using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailc;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetailc
{
    public class FinanceDashCrmDetailcOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashCrmDetailcRequestInitialModel InitialModel { get; set; }
    }
}
