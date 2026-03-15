using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.upcmconsole;
using fincheckup.ApiClients.Models.Requests.upcmconsole;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpCmconsoleApiClient : IApiClientBase
{
    [Post("/api/upcmconsole")]
    Task<GenericResult<upcmconsoleOnGetResponse>> GetAsync(
        [Body] upcmconsoleOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcmconsole/saler-date")]
    Task<GenericResult<upcmconsoleOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upcmconsoleOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcmconsole/saler-year")]
    Task<GenericResult<upcmconsoleOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upcmconsoleOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcmconsole/saler-comp")]
    Task<GenericResult<upcmconsoleOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upcmconsoleOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcmconsole/graph-comp")]
    Task<GenericResult<upcmconsoleOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upcmconsoleOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcmconsole/graph-year")]
    Task<GenericResult<upcmconsoleOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upcmconsoleOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}
