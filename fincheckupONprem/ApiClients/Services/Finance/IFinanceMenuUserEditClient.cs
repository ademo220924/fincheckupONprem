using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuUserEditController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuUserEditController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuUserEditClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGet")]
    Task<GenericResult<UserEditOnGetResponse>> GetAsync([Body] UserEditOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetSalerCity")]
    Task<GenericResult<UserEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] UserEditOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetSalerCompany")]
    Task<GenericResult<UserEditOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] UserEditOnGetSalerCompanyRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetUser")]
    Task<GenericResult<UserEditOnGetUserResponse>> GetUserAsync([Body] UserEditOnGetUserRequest request, CancellationToken cancellationToken = default);
}
