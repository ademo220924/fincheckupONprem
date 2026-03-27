using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuCompanyEditController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuCompanyEditController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuCompanyEditClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGet")]
    Task<GenericResult<CompanyEditOnGetResponse>> GetAsync([Body] CompanyEditOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGetSalerEnteg")]
    Task<GenericResult<CompanyEditOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] CompanyEditOnGetSalerEntegRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGetSalerCity")]
    Task<GenericResult<CompanyEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] CompanyEditOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
}
