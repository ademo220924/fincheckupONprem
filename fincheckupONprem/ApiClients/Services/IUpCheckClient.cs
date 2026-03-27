using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpCheckController. Source: src/FinanceCheckUp.Api/Controllers/v1/upcheckController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpCheckClient : IApiClientBase
{
    [Post("/api/upcheck")]
    Task<GenericResult<upcheckOnGetResponse>> GetAsync([Body] upcheckOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/saler-date")]
    Task<GenericResult<upcheckOnGetSalerDateResponse>> GetSalerDateAsync([Body] upcheckOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/check-rep-pdf")]
    Task<GenericResult<upcheckOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] upcheckOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/check-rep-xls")]
    Task<GenericResult<upcheckOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] upcheckOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/saler-year")]
    Task<GenericResult<upcheckOnGetSalerYearResponse>> GetSalerYearAsync([Body] upcheckOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/saler-comp")]
    Task<GenericResult<upcheckOnGetSalerCompResponse>> GetSalerCompAsync([Body] upcheckOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/graph-comp")]
    Task<GenericResult<upcheckOnGetGraphCompResponse>> GetGraphCompAsync([Body] upcheckOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcheck/graph-year")]
    Task<GenericResult<upcheckOnGetGraphYearResponse>> GetGraphYearAsync([Body] upcheckOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
