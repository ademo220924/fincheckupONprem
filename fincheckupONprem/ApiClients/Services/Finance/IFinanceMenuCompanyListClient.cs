using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuCompanyListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuCompanyListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuCompanyListClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyList/OnGet")]
    Task<GenericResult<CompanyListOnGetResponse>> GetAsync([Body] CompanyListOnGetRequest request, CancellationToken cancellationToken = default);
}
