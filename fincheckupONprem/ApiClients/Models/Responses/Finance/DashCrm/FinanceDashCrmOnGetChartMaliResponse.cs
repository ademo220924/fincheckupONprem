using fincheckup.ApiClients.Models.Requests.Finance.DashCrm;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrm
{
    public class FinanceDashCrmOnGetChartMaliResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashCrmRequestInitialModel InitialModel { get; set; }
    }
}
