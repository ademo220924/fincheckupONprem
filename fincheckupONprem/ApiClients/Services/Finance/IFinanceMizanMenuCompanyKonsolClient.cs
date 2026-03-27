using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuCompanyKonsolController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuCompanyKonsolController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuCompanyKonsolClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyKonsol/OnGet")]
    Task<GenericResult<MizanCompanyKonsolOnGetResponse>> GetAsync([Body] MizanCompanyKonsolOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyKonsol/OnGetSalerEnteg")]
    Task<GenericResult<MizanCompanyKonsolOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] MizanCompanyKonsolOnGetSalerEntegRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyKonsol/OnGetSalerCity")]
    Task<GenericResult<MizanCompanyKonsolOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanCompanyKonsolOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
}
