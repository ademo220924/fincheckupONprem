using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyList;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyList
{
    public class MizanCompanyListOnGetResponse
    {
        public MizanCompanyListRequestInitialModel InitialModel { get; set; }
        public string ResponseRedirectUrl { get; set; } = string.Empty;
    }
}
