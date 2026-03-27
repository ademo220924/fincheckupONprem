using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpBalanceaktController. Source: src/FinanceCheckUp.Api/Controllers/v1/upbalanceaktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpBalanceaktClient : IApiClientBase
{
    [Post("/api/upbalanceakt")]
    Task<GenericResult<upbalanceaktOnGetResponse>> GetAsync([Body] upbalanceaktOnGetRequest request, CancellationToken cancellationToken = default);
}
