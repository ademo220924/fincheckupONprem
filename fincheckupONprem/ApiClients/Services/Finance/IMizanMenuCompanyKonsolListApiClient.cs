using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuCompanyKonsolListApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/CompanyKonsolList/OnGet")]
    Task<GenericResult<MizanCompanyKonsolListOnGetResponse>> GetAsync([Body] MizanCompanyKonsolListOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/CompanyKonsolList/OnGetKonList")]
    Task<GenericResult<MizanCompanyKonsolListOnGetKonListResponse>> GetKonListAsync([Body] MizanCompanyKonsolListOnGetKonListRequest request, CancellationToken cancellationToken);
}