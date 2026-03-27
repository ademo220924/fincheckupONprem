using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancorvnaktController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancorvnaktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancorvnaktClient : IApiClientBase
{
    [Post("/api/dashbilancorvnakt")]
    Task<GenericResult<dashbilancorvnaktOnGetResponse>> GetAsync([Body] dashbilancorvnaktOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnakt/saler-main")]
    Task<GenericResult<dashbilancorvnaktOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancorvnaktOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnakt/prio")]
    Task<GenericResult<dashbilancorvnaktOnGetPrioResponse>> GetPrioAsync([Body] dashbilancorvnaktOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnakt/graph-year")]
    Task<GenericResult<dashbilancorvnaktOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancorvnaktOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnakt/graph-comp")]
    Task<GenericResult<dashbilancorvnaktOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancorvnaktOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
