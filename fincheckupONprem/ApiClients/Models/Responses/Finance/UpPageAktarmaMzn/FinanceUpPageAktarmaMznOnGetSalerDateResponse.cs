using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaMzn
{
    public class FinanceUpPageAktarmaMznOnGetSalerDateResponse
    {
        public JsonElement? Response { get; set; }
        public FinanceUpPageAktarmaMznRequestInitialModel InitialModel { get; set; }
    }
}
