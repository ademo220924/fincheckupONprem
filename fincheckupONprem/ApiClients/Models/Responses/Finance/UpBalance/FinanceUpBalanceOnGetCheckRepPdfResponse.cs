using fincheckup.ApiClients.Models.Requests.Finance.UpBalance;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpBalanceRequestInitialModel InitialModel { get; set; }
    }
}
