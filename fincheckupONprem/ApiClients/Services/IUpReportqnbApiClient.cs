using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upreportqnb;
using fincheckup.ApiClients.Models.Responses.upreportqnb;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpReportqnbApiClient : IApiClientBase
{
    [Post("/api/upreportqnb")]
    Task<GenericResult<upreportqnbOnGetResponse>> GetAsync(
        [Body] upreportqnbOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/saler-date")]
    Task<GenericResult<upreportqnbOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upreportqnbOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/saler-year")]
    Task<GenericResult<upreportqnbOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upreportqnbOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/get-rep")]
    Task<GenericResult<upreportqnbOnGetGetRepResponse>> GetGetRepAsync(
        [Body] upreportqnbOnGetGetRepRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/check-rep")]
    Task<GenericResult<upreportqnbOnGetCheckRepResponse>> GetCheckRepAsync(
        [Body] upreportqnbOnGetCheckRepRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/saler-comp")]
    Task<GenericResult<upreportqnbOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upreportqnbOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/graph-comp")]
    Task<GenericResult<upreportqnbOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upreportqnbOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportqnb/graph-year")]
    Task<GenericResult<upreportqnbOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upreportqnbOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}

