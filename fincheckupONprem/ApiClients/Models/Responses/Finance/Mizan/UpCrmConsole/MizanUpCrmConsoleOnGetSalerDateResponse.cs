using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpCrmConsole;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpCrmConsole
{
    public class MizanUpCrmConsoleOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public MizanUpCrmConsoleRequestInitialModel InitialModel { get; set; }
    }
}
