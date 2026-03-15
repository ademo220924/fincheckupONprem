using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upreportmainy;
using fincheckup.ApiClients.Models.Responses.upreportmainy;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpReportmainyApiClient : IApiClientBase
{
    [Post("/api/upreportmainy")]
    Task<GenericResult<upreportmainyOnGetResponse>> GetAsync(
        [Body] UpreportmainyOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportmainy/saler-date")]
    Task<GenericResult<upreportmainyOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upreportmainyOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportmainy/saler-year")]
    Task<GenericResult<upreportmainyOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upreportmainyOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportmainy/saler-comp")]
    Task<GenericResult<upreportmainyOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upreportmainyOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportmainy/graph-comp")]
    Task<GenericResult<upreportmainyOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upreportmainyOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upreportmainy/graph-year")]
    Task<GenericResult<upreportmainyOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upreportmainyOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}
