using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.ChangePassword;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.ChangePassword;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IChangePasswordApiClient: IApiClientBase
{
    [Post("/api/chance-password")]
    Task<GenericResult<ChangePasswordOnGetResponse>> GetAsync([Body] ChangePasswordOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/chance-password/saler-main")]
    Task<GenericResult<ChangePasswordOnGetSalerMainResponse>> GetSalerMainAsync([Body] ChangePasswordOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/chance-password/saler-city")]
    Task<GenericResult<ChangePasswordOnGetSalerCityResponse>> GetSalerCityAsync([Body] ChangePasswordOnGetSalerCityRequest request, CancellationToken cancellationToken);

    [Post("/api/chance-password/saler-company")]
    Task<GenericResult<ChangePasswordOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] ChangePasswordOnGetSalerCompanyRequest request, CancellationToken cancellationToken);

    [Post("/api/chance-password/user")]
    Task<GenericResult<ChangePasswordOnGetUserResponse>> GetUserAsync([Body] ChangePasswordOnGetUserRequest request, CancellationToken cancellationToken);

}
