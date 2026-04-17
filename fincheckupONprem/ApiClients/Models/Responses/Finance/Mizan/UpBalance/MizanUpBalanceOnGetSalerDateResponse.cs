using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpBalanceRequestInitialModel InitialModel { get; set; }
    }
}
