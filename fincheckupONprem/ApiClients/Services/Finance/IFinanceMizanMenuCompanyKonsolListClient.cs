using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuCompanyKonsolListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuCompanyKonsolListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuCompanyKonsolListClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyKonsolList/OnGet")]
    Task<GenericResult<MizanCompanyKonsolListOnGetResponse>> GetAsync([Body] MizanCompanyKonsolListOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyKonsolList/OnGetKonList")]
    Task<GenericResult<MizanCompanyKonsolListOnGetKonListResponse>> GetKonListAsync([Body] MizanCompanyKonsolListOnGetKonListRequest request, CancellationToken cancellationToken = default);
}
