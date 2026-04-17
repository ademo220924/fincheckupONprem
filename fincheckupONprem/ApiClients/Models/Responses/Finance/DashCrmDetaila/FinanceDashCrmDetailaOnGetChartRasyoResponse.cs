using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetaila;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetaila
{
    public class FinanceDashCrmDetailaOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashCrmDetailaRequestInitialModel InitialModel { get; set; }
    }
}
