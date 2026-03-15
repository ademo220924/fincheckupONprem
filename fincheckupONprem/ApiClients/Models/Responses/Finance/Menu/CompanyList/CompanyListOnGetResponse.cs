using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyList;

namespace fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyList
{
    public class CompanyListOnGetResponse
    {
        public CompanyListInitialModel InitialModel { get; set; }
        public string RedirecrUrl { get; set; }
    }
}
