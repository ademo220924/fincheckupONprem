using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpCmconsoleController. Source: src/FinanceCheckUp.Api/Controllers/v1/upcmconsoleController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpCmconsoleClient : IApiClientBase
{
    [Post("/api/upcmconsole")]
    Task<GenericResult<upcmconsoleOnGetResponse>> GetAsync([Body] upcmconsoleOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcmconsole/saler-date")]
    Task<GenericResult<upcmconsoleOnGetSalerDateResponse>> GetSalerDateAsync([Body] upcmconsoleOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcmconsole/saler-year")]
    Task<GenericResult<upcmconsoleOnGetSalerYearResponse>> GetSalerYearAsync([Body] upcmconsoleOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcmconsole/saler-comp")]
    Task<GenericResult<upcmconsoleOnGetSalerCompResponse>> GetSalerCompAsync([Body] upcmconsoleOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcmconsole/graph-comp")]
    Task<GenericResult<upcmconsoleOnGetGraphCompResponse>> GetGraphCompAsync([Body] upcmconsoleOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upcmconsole/graph-year")]
    Task<GenericResult<upcmconsoleOnGetGraphYearResponse>> GetGraphYearAsync([Body] upcmconsoleOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
