using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyList;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuCompanyListApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyList/OnGet")]
    Task<GenericResult<CompanyListOnGetResponse>> GetAsync([Body] CompanyListOnGetRequest request, CancellationToken cancellationToken);
}