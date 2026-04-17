using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtNeo
{
    public class FinanceFinanceHrtNeoOnGetMarkupMarjinAResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceFinanceHrtNeoRequestInitialModel InitialModel { get; set; }
    }
}
