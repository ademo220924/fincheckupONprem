using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancorvnmltController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancorvnmltController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancorvnmltClient : IApiClientBase
{
    [Post("/api/dashbilancorvnmlt")]
    Task<GenericResult<dashbilancorvnmltOnGetResponse>> GetAsync([Body] DashbilancorvnmltOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/saler-main")]
    Task<GenericResult<dashbilancorvnmltOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancorvnmltOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/prio")]
    Task<GenericResult<dashbilancorvnmltOnGetPrioResponse>> GetPrioAsync([Body] dashbilancorvnmltOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/graph-year")]
    Task<GenericResult<dashbilancorvnmltOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancorvnmltOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/chart-rasyo")]
    Task<GenericResult<dashbilancorvnmltOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] dashbilancorvnmltOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/markup-marjin")]
    Task<GenericResult<dashbilancorvnmltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] dashbilancorvnmltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancorvnmlt/graph-comp")]
    Task<GenericResult<dashbilancorvnmltOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancorvnmltOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
