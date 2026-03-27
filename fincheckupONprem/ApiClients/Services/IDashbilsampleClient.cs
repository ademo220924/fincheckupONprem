using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilsampleController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilsampleController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilsampleClient : IApiClientBase
{
    [Post("/api/dashbilsample")]
    Task<GenericResult<dashbilsampleOnGetResponse>> GetAsync([Body] dashbilsampleOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilsample/saler-main")]
    Task<GenericResult<dashbilsampleOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilsampleOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilsample/prio")]
    Task<GenericResult<dashbilsampleOnGetPrioResponse>> GetPrioAsync([Body] dashbilsampleOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilsample/graph-year")]
    Task<GenericResult<dashbilsampleOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilsampleOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilsample/graph-comp")]
    Task<GenericResult<dashbilsampleOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilsampleOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
