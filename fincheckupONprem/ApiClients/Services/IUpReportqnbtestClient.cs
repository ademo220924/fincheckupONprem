using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpReportqnbtestController. Source: src/FinanceCheckUp.Api/Controllers/v1/upreportqnbtestController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpReportqnbtestClient : IApiClientBase
{
    [Post("/api/upreportqnbtest")]
    Task<GenericResult<upreportqnbtestOnGetResponse>> GetAsync([Body] upreportqnbtestOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/saler-date")]
    Task<GenericResult<upreportqnbtestOnGetSalerDateResponse>> GetSalerDateAsync([Body] upreportqnbtestOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/saler-year")]
    Task<GenericResult<upreportqnbtestOnGetSalerYearResponse>> GetSalerYearAsync([Body] upreportqnbtestOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/get-rep")]
    Task<GenericResult<upreportqnbtestOnGetGetRepResponse>> GetGetRepAsync([Body] upreportqnbtestOnGetGetRepRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/check-rep")]
    Task<GenericResult<upreportqnbtestOnGetCheckRepResponse>> GetCheckRepAsync([Body] upreportqnbtestOnGetCheckRepRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/saler-comp")]
    Task<GenericResult<upreportqnbtestOnGetSalerCompResponse>> GetSalerCompAsync([Body] upreportqnbtestOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/graph-comp")]
    Task<GenericResult<upreportqnbtestOnGetGraphCompResponse>> GetGraphCompAsync([Body] upreportqnbtestOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upreportqnbtest/graph-year")]
    Task<GenericResult<upreportqnbtestOnGetGraphYearResponse>> GetGraphYearAsync([Body] upreportqnbtestOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
