using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancomznController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancomznController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancomznClient : IApiClientBase
{
    [Post("/api/dashbilancomzn")]
    Task<GenericResult<dashbilancomznOnGetResponse>> GetAsync([Body] dashbilancomznOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomzn/saler-main")]
    Task<GenericResult<dashbilancomznOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancomznOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomzn/prio")]
    Task<GenericResult<dashbilancomznOnGetPrioResponse>> GetPrioAsync([Body] dashbilancomznOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomzn/graph-year")]
    Task<GenericResult<dashbilancomznOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancomznOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomzn/graph-comp")]
    Task<GenericResult<dashbilancomznOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancomznOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
