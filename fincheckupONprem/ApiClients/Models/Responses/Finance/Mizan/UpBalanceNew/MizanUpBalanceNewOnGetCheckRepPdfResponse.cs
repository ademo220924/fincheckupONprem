using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpBalanceNewRequestInitialModel InitialModel { get; set; }
    }
}
