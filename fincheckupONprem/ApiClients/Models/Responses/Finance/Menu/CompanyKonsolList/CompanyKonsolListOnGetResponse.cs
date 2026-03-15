using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList;

namespace fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyKonsolList
{
    public class CompanyKonsolListOnGetResponse
    {
        public CompanyKonsolListInitialModel InitialModel { get; set; }
        public string RedirectUrl { get; set; }
    }
}