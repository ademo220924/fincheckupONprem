using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upreportqnbtest;
using fincheckup.ApiClients.Models.Responses.upreportqnbtest;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpReportqnbtestApiClient : IApiClientBase
{
    [Post("/api/upreportqnbtest")]
    Task<GenericResult<upreportqnbtestOnGetResponse>> GetAsync(
        [Body] upreportqnbtestOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/saler-date")]
    Task<GenericResult<upreportqnbtestOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upreportqnbtestOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/saler-year")]
    Task<GenericResult<upreportqnbtestOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upreportqnbtestOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/get-rep")]
    Task<GenericResult<upreportqnbtestOnGetGetRepResponse>> GetGetRepAsync(
        [Body] upreportqnbtestOnGetGetRepRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/check-rep")]
    Task<GenericResult<upreportqnbtestOnGetCheckRepResponse>> GetCheckRepAsync(
        [Body] upreportqnbtestOnGetCheckRepRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/saler-comp")]
    Task<GenericResult<upreportqnbtestOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upreportqnbtestOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/graph-comp")]
    Task<GenericResult<upreportqnbtestOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upreportqnbtestOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnbtest/graph-year")]
    Task<GenericResult<upreportqnbtestOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upreportqnbtestOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}