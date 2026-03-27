using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuCompanyKonsolListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuCompanyKonsolListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuCompanyKonsolListClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyKonsolList/OnGet")]
    Task<GenericResult<CompanyKonsolListOnGetResponse>> GetAsync([Body] CompanyKonsolListOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuCompanyKonsolList/OnGetKonList")]
    Task<GenericResult<CompanyKonsolListOnGetKonListResponse>> GetKonListAsync([Body] CompanyKonsolListOnGetKonListRequest request, CancellationToken cancellationToken = default);
}
