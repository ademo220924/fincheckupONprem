using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.CashFlow
{
    public class FinanceCashFlowOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceCashFlowRequestInitialModel InitialModel { get; set; }
    }
}
