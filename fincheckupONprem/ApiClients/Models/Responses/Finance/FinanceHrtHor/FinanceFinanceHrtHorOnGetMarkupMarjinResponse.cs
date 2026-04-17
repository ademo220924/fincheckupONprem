using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtHor
{
    public class FinanceFinanceHrtHorOnGetMarkupMarjinResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceFinanceHrtHorRequestInitialModel InitialModel { get; set; }
    }
}
