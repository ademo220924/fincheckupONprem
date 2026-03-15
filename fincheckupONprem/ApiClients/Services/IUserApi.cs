using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.Users;
using fincheckup.ApiClients.Models.Requests.Users;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUserApiClient : IApiClientBase
{
    [Post("/api/user/change-password")]
    Task<GenericResult<UserPasswordChangeResponse>> ChangePasswordAsync(
        [Body] UserPasswordChangeRequest request,
        CancellationToken cancellationToken);

    [Post("/api/user/update-companies")]
    Task<GenericResult<UserCompanyUpdateResponse>> UserCompanyUpdateAsync(
        [Body] UserCompanyUpdateRequest request,
        CancellationToken cancellationToken);


    [Delete("/delete/id/{id}")]
    Task<ApiResponse<UserDeleteResponse>> DeleteAsync(
        [Header("user-id")] string userId,
        long id,
        CancellationToken cancellationToken);

    [Post("/api/user/crete")]
    Task<GenericResult<CreateUserResponse>> CreateAsync(
        [Body] CreateUserRequest command,
        CancellationToken cancellationToken);

    [Put("/api/user/update")]
    Task<GenericResult<UserCompanyUpdateResponse>> UpdateAsync(
        [Body] UserCompanyUpdateRequest command,
        CancellationToken cancellationToken);


    [Get("/api/user/types")]
    Task<GenericResult<UserTypesResponse>> GetTypesAsync(CancellationToken cancellationToken = default);

    [Get("/api/user/type/id/{id}")]
    Task<GenericResult<UserTypeResponse>> GetTypeByIdAsync(int id, CancellationToken cancellationToken = default);

   
}