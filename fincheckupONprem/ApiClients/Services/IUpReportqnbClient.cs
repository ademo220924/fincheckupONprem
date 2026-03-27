using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpReportqnbController. Source: src/FinanceCheckUp.Api/Controllers/v1/upreportqnbController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpReportqnbClient : IApiClientBase
{
    [Post("/api/upreportqnb")]
    Task<GenericResult<upreportqnbOnGetResponse>> GetAsync([Body] upreportqnbOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/saler-date")]
    Task<GenericResult<upreportqnbOnGetSalerDateResponse>> GetSalerDateAsync([Body] upreportqnbOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/saler-year")]
    Task<GenericResult<upreportqnbOnGetSalerYearResponse>> GetSalerYearAsync([Body] upreportqnbOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/get-rep")]
    Task<GenericResult<upreportqnbOnGetGetRepResponse>> GetGetRepAsync([Body] upreportqnbOnGetGetRepRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/check-rep")]
    Task<GenericResult<upreportqnbOnGetCheckRepResponse>> GetCheckRepAsync([Body] upreportqnbOnGetCheckRepRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/saler-comp")]
    Task<GenericResult<upreportqnbOnGetSalerCompResponse>> GetSalerCompAsync([Body] upreportqnbOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/graph-comp")]
    Task<GenericResult<upreportqnbOnGetGraphCompResponse>> GetGraphCompAsync([Body] upreportqnbOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnb/graph-year")]
    Task<GenericResult<upreportqnbOnGetGraphYearResponse>> GetGraphYearAsync([Body] upreportqnbOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
