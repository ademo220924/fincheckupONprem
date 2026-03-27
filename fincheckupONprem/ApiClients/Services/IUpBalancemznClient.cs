using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpBalancemznController. Source: src/FinanceCheckUp.Api/Controllers/v1/upbalancemznController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpBalancemznClient : IApiClientBase
{
    [Post("/api/upbalancemzn")]
    Task<GenericResult<upbalancemznOnGetResponse>> GetAsync([Body] upbalancemznOnGetRequest request, CancellationToken cancellationToken = default);
}
