using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsolList;

public class MizanCompanyKonsolListOnGetKonListResponse
{
    public JsonElement? Response { get; set; }
    public MizanCompanyKonsolListRequestInitialModel InitialModel { get; set; }
}
