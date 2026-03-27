using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upaccounty;
using fincheckup.ApiClients.Models.Responses.upaccounty;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpAccountyApiClient : IApiClientBase
{
    [Post("/api/upaccounty")]
    Task<GenericResult<upaccountyOnGetResponse>> GetAsync(
        [Body] UpaccountyOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/saler-main-chk")]
    Task<GenericResult<upaccountyOnGetSalerMainChkResponse>> GetSalerMainChkAsync(
        [Body] upaccountyOnGetSalerMainChkRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/saler-main-zeta")]
    Task<GenericResult<upaccountyOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync(
        [Body] upaccountyOnGetSalerMainZetaRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/saler-date")]
    Task<GenericResult<upaccountyOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upaccountyOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/saler-year")]
    Task<GenericResult<upaccountyOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upaccountyOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/saler-comp")]
    Task<GenericResult<upaccountyOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upaccountyOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/graph-comp")]
    Task<GenericResult<upaccountyOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upaccountyOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccounty/graph-year")]
    Task<GenericResult<upaccountyOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upaccountyOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}
