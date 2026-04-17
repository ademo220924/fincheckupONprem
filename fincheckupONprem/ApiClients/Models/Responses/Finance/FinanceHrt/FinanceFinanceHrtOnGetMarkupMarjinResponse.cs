using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrt
{
    public class FinanceFinanceHrtOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceFinanceHrtRequestInitialModel InitialModel { get; set; }
    }
}
