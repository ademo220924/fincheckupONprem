using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for dashbilancoaktController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashBilancoAktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IdashbilancoaktClient : IApiClientBase
{
    [Post("/api/dashbilancoakt")]
    Task<GenericResult<dashbilancoaktOnGetResponse>> GetAsync([Body] dashbilancoaktOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancoakt/saler-main")]
    Task<GenericResult<dashbilancoaktOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancoaktOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancoakt/prio")]
    Task<GenericResult<dashbilancoaktOnGetPrioResponse>> GetPrioAsync([Body] dashbilancoaktOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancoakt/graph-year")]
    Task<GenericResult<dashbilancoaktOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancoaktOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancoakt/graph-comp")]
    Task<GenericResult<dashbilancoaktOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancoaktOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
