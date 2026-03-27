using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpCheckyController. Source: src/FinanceCheckUp.Api/Controllers/v1/upcheckyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpCheckyClient : IApiClientBase
{
    [Post("/api/upchecky")]
    Task<GenericResult<upcheckyOnGetResponse>> GetAsync([Body] UpcheckyOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upchecky/saler-date")]
    Task<GenericResult<upcheckyOnGetSalerDateResponse>> GetSalerDateAsync([Body] upcheckyOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upchecky/saler-year")]
    Task<GenericResult<upcheckyOnGetSalerYearResponse>> GetSalerYearAsync([Body] upcheckyOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upchecky/saler-comp")]
    Task<GenericResult<upcheckyOnGetSalerCompResponse>> GetSalerCompAsync([Body] upcheckyOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upchecky/graph-comp")]
    Task<GenericResult<upcheckyOnGetGraphCompResponse>> GetGraphCompAsync([Body] upcheckyOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upchecky/graph-year")]
    Task<GenericResult<upcheckyOnGetGraphYearResponse>> GetGraphYearAsync([Body] upcheckyOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
