using fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpCrmConsole
{
    public class FinanceUpCrmConsoleOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpCrmConsoleRequestInitialModel InitialModel { get; set; }
    }
}
