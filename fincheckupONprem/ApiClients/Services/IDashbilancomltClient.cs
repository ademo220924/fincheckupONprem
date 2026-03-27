using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancomltController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancomltController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancomltClient : IApiClientBase
{
    [Post("/api/dashbilancomlt")]
    Task<GenericResult<dashbilancomltOnGetResponse>> GetAsync([Body] dashbilancomltOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/saler-main")]
    Task<GenericResult<dashbilancomltOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancomltOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/prio")]
    Task<GenericResult<dashbilancomltOnGetPrioResponse>> GetPrioAsync([Body] dashbilancomltOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/graph-year")]
    Task<GenericResult<dashbilancomltOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancomltOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/chart-rasyo")]
    Task<GenericResult<dashbilancomltOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] dashbilancomltOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/markup-marjin")]
    Task<GenericResult<dashbilancomltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] dashbilancomltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancomlt/graph-comp")]
    Task<GenericResult<dashbilancomltOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancomltOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
