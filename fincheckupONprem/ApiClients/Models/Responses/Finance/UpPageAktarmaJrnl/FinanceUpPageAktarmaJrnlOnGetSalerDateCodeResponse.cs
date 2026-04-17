using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlOnGetSalerDateCodeResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpPageAktarmaJrnlRequestInitialModel InitialModel { get; set; }
    }
}
