using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.UserEdit;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuUserEditApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGet")]
    Task<GenericResult<UserEditOnGetResponse>> GetAsync([Body] UserEditOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetSalerCity")]
    Task<GenericResult<UserEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] UserEditOnGetSalerCityRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetSalerCompany")]
    Task<GenericResult<UserEditOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] UserEditOnGetSalerCompanyRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuUserEdit/OnGetUser")]
    Task<GenericResult<UserEditOnGetUserResponse>> GetUserAsync([Body] UserEditOnGetUserRequest request, CancellationToken cancellationToken);
}