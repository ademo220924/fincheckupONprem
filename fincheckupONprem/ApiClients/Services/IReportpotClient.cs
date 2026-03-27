using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReportpotController. Source: src/FinanceCheckUp.Api/Controllers/v1/reportpotController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReportpotClient : IApiClientBase
{
    [Post("/api/reportpot")]
    Task<GenericResult<reportpotOnGetResponse>> GetAsync([Body] reportpotOnGetRequest request, CancellationToken cancellationToken = default);
}
