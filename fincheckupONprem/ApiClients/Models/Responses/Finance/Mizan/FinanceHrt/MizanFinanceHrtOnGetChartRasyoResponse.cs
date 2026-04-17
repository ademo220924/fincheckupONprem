using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrt
{
    public class MizanFinanceHrtOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanFinanceHrtRequestInitialModel InitialModel { get; set; }
    }
}
