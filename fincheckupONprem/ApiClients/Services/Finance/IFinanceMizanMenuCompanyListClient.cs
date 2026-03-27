using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuCompanyListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuCompanyListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuCompanyListClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/CompanyList/OnGet")]
    Task<GenericResult<MizanCompanyListOnGetResponse>> GetAsync([Body] MizanCompanyListOnGetRequest request, CancellationToken cancellationToken = default);
}
