using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtNeo
{
    public class MizanFinanceHrtNeoOnGetChartRasyoResponse
    {
        public JsonElement? Response { get; set; }
        public MizanFinanceHrtNeoRequestInitialModel InitialModel { get; set; }
    }
}
