using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceHrtNeoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceHrtNeoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceHrtNeoClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrtNeo/OnGet")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetResponse>> GetAsync([Body] FinanceFinanceHrtNeoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtNeo/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtNeoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
}
