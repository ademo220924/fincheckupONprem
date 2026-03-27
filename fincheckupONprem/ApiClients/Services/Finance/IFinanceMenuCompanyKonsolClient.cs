using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsol;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuCompanyKonsolController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuCompanyKonsolController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuCompanyKonsolClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGet")]
    Task<GenericResult<CompanyKonsolOnGetResponse>> GetAsync([Body] CompanyKonsolOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGetSalerEnteg")]
    Task<GenericResult<CompanyKonsolOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] CompanyKonsolOnGetSalerEntegRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGetSalerCity")]
    Task<GenericResult<CompanyKonsolOnGetSalerCityResponse>> GetSalerCityAsync([Body] CompanyKonsolOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
}
