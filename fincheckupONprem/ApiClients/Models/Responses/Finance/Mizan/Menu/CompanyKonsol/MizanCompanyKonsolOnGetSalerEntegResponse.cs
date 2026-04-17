using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsol
{
    public class MizanCompanyKonsolOnGetSalerEntegResponse
    {
        public JsonElement? Response { get; set; }
        public MizanCompanyKonsolRequestInitialModel InitialModel { get; set; }
    }
}
