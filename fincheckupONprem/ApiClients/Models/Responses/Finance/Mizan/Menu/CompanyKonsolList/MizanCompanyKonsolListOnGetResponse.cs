using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsolList;

public class MizanCompanyKonsolListOnGetResponse
{
    public MizanCompanyKonsolListRequestInitialModel InitialModel { get; set; }
    public string ResponseRedirectUrl { get; set; } = string.Empty;
}
