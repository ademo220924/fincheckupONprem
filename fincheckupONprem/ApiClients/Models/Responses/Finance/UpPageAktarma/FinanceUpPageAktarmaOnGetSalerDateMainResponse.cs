using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarma
{
    public class FinanceUpPageAktarmaOnGetSalerDateMainResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
