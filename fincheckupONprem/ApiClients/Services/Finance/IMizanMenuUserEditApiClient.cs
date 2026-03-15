using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.UserEdit;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuUserEditApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/UserEdit/OnGet")]
    Task<GenericResult<MizanUserEditOnGetResponse>> GetAsync([Body] MizanUserEditOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/UserEdit/OnGetSalerCity")]
    Task<GenericResult<MizanUserEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanUserEditOnGetSalerCityRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/UserEdit/OnGetSalerCompany")]
    Task<GenericResult<MizanUserEditOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] MizanUserEditOnGetSalerCompanyRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/UserEdit/OnGetUser")]
    Task<GenericResult<MizanUserEditOnGetUserResponse>> GetUserAsync([Body] MizanUserEditOnGetUserRequest request, CancellationToken cancellationToken);
}