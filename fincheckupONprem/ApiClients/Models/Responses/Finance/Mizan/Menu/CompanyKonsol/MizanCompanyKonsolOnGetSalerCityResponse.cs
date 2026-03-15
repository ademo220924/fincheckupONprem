using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsol
{
    public class MizanCompanyKonsolOnGetSalerCityResponse
    {
        public JsonResult Response { get; set; }
        public MizanCompanyKonsolRequestInitialModel InitialModel { get; set; }
    }
}
