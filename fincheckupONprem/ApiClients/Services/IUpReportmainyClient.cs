using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpReportmainyController. Source: src/FinanceCheckUp.Api/Controllers/v1/upreportmainyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpReportmainyClient : IApiClientBase
{
    [Post("/api/upreportmainy")]
    Task<GenericResult<upreportmainyOnGetResponse>> GetAsync([Body] UpreportmainyOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportmainy/saler-date")]
    Task<GenericResult<upreportmainyOnGetSalerDateResponse>> GetSalerDateAsync([Body] upreportmainyOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportmainy/saler-year")]
    Task<GenericResult<upreportmainyOnGetSalerYearResponse>> GetSalerYearAsync([Body] upreportmainyOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportmainy/saler-comp")]
    Task<GenericResult<upreportmainyOnGetSalerCompResponse>> GetSalerCompAsync([Body] upreportmainyOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportmainy/graph-comp")]
    Task<GenericResult<upreportmainyOnGetGraphCompResponse>> GetGraphCompAsync([Body] upreportmainyOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportmainy/graph-year")]
    Task<GenericResult<upreportmainyOnGetGraphYearResponse>> GetGraphYearAsync([Body] upreportmainyOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
