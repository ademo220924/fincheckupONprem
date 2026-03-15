using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyList;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuCompanyListApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/CompanyList/OnGet")]
    Task<GenericResult<MizanCompanyListOnGetResponse>> GetAsync([Body] MizanCompanyListOnGetRequest request, CancellationToken cancellationToken);
}