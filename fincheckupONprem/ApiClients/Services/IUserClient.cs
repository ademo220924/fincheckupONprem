using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Models.Requests.Users;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UserController. Source: src/FinanceCheckUp.Api/Controllers/v1/UserController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUserClient : IApiClientBase
{
    [Post("/api/user/change-password")]
    Task<GenericResult<UserPasswordChangeResponse>> ChangePasswordAsync([Body] UserPasswordChangeRequest request, CancellationToken cancellationToken = default);
    [Post("/api/user/update-companies")]
    Task<object> UserCompanyUpdateAsync([Body] UserCompanyUpdateRequest request, CancellationToken cancellationToken = default);
    [Delete("/api/user/delete/id/{id}")]
    Task<GenericResult<UserDeleteResponse>> DeleteAsync([Body] UserDeleteRequest body, CancellationToken cancellationToken = default);
    [Post("/api/user/crete")]
    Task<GenericResult<CreateUserResponse>> CreateAsync([Body] CreateUserRequest request, CancellationToken cancellationToken = default);
    [Put("/api/user/update")]
    Task<GenericResult<UserCompanyUpdateResponse>> UpdateAsync([Body] UserCompanyUpdateRequest request, CancellationToken cancellationToken = default);
    [Get("/api/user/types")]
    Task<GenericResult<UserTypesResponse>> GetUserTypesAsync(CancellationToken cancellationToken = default);
    [Get("/api/user/type/id/{id:int}")]
    Task<GenericResult<UserTypeResponse>> GetUserTypeByIdAsync(int id, CancellationToken cancellationToken = default);
}
