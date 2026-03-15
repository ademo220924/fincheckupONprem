using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuCompanyKonsolListApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyKonsolList/OnGet")]
    Task<GenericResult<CompanyKonsolListOnGetResponse>> GetAsync([Body] CompanyKonsolListOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuCompanyKonsolList/OnGetKonList")]
    Task<GenericResult<CompanyKonsolListOnGetKonListResponse>> GetKonListAsync([Body] CompanyKonsolListOnGetKonListRequest request, CancellationToken cancellationToken);
}