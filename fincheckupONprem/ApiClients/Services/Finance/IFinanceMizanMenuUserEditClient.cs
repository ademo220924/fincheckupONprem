using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuUserEditController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuUserEditController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuUserEditClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuUserEdit/OnGet")]
    Task<GenericResult<MizanUserEditOnGetResponse>> GetAsync([Body] MizanUserEditOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuUserEdit/OnGetSalerCity")]
    Task<GenericResult<MizanUserEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanUserEditOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuUserEdit/OnGetSalerCompany")]
    Task<GenericResult<MizanUserEditOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] MizanUserEditOnGetSalerCompanyRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/menu/FinanceMizanMenuUserEdit/OnGetUser")]
    Task<GenericResult<MizanUserEditOnGetUserResponse>> GetUserAsync([Body] MizanUserEditOnGetUserRequest request, CancellationToken cancellationToken = default);
}
