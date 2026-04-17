using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetail
{
    public class FinanceDashCrmDetailOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceDashCrmDetailRequestInitialModel Request { get; set; }
    }
}
