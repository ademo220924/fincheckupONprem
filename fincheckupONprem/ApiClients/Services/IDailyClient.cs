using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DailyController. Source: src/FinanceCheckUp.Api/Controllers/v1/DailyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDailyClient : IApiClientBase
{
    [Post("/api/daily/create")]
    Task<GenericResult<DailyCreateResponse>> CreateAsync([Body] DailyCreateRequest request, CancellationToken cancellationToken = default);
    [Put("/api/daily/{id:int}/update")]
    Task<GenericResult<DailyUpdateResponse>> UpdateAsync([Body] DailyUpdateRequest request, CancellationToken cancellationToken = default);
    [Delete("/api/daily/{id:int}/delete")]
    Task<GenericResult<DailyDeleteResponse>> DeleteAsync([Body] DailyDeleteRequest body, CancellationToken cancellationToken = default);
    [Post("/api/daily/{year:int}/list")]
    Task<GenericResult<DailyGetListResponse>> GetListAsync([Body] DailyGetListRequest request, CancellationToken cancellationToken = default);
    [Post("/api/daily/Priority")]
    Task<GenericResult<DailyGetPriorityResponse>> GetPriorityAsync([Body] DailyPrioritytRequest request, CancellationToken cancellationToken = default);
}
