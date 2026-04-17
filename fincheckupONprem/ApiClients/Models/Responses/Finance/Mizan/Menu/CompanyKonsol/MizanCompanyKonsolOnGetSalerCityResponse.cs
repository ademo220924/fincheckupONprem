using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsol
{
    public class MizanCompanyKonsolOnGetSalerCityResponse
    {
        public JsonElement? Response { get; set; }
        public MizanCompanyKonsolRequestInitialModel InitialModel { get; set; }
    }
}
