using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancorvnmznController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancorvnmznController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancorvnmznClient : IApiClientBase
{
    [Post("/api/dashbilancorvnmzn")]
    Task<GenericResult<dashbilancorvnmznOnGetResponse>> GetAsync([Body] dashbilancorvnmznOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmzn/saler-main")]
    Task<GenericResult<dashbilancorvnmznOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancorvnmznOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmzn/prio")]
    Task<GenericResult<dashbilancorvnmznOnGetPrioResponse>> GetPrioAsync([Body] dashbilancorvnmznOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmzn/graph-year")]
    Task<GenericResult<dashbilancorvnmznOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancorvnmznOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmzn/graph-comp")]
    Task<GenericResult<dashbilancorvnmznOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancorvnmznOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
