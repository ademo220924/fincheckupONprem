using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyEdit;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuCompanyEditController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuCompanyEditController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuCompanyEditClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyEdit/OnGet")]
    Task<GenericResult<MizanCompanyEditOnGetResponse>> GetAsync([Body] MizanCompanyEditOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyEdit/OnGetSalerEnteg")]
    Task<GenericResult<MizanCompanyEditOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] MizanCompanyEditOnGetSalerEntegRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuCompanyEdit/OnGetSalerCity")]
    Task<GenericResult<MizanCompanyEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanCompanyEditOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
}
