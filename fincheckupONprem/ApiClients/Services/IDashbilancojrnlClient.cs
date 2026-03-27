using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashbilancojrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/dashbilancojrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashbilancojrnlClient : IApiClientBase
{
    [Post("/api/dashbilancojrnl")]
    Task<GenericResult<dashbilancojrnlOnGetResponse>> GetAsync([Body] dashbilancojrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancojrnl/saler-main")]
    Task<GenericResult<dashbilancojrnlOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancojrnlOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancojrnl/prio")]
    Task<GenericResult<dashbilancojrnlOnGetPrioResponse>> GetPrioAsync([Body] dashbilancojrnlOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancojrnl/graph-year")]
    Task<GenericResult<dashbilancojrnlOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancojrnlGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancojrnl/graph-comp")]
    Task<GenericResult<dashbilancojrnlOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancojrnlOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilancojrnl/markup-marjin")]
    Task<GenericResult<dashbilancojrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] dashbilancojrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
