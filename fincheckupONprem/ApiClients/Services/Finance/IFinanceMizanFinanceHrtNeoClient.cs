using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanFinanceHrtNeoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanFinanceHrtNeoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanFinanceHrtNeoClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtNeo/OnGet")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetResponse>> GetAsync([Body] FinanceHrtNeoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtNeo/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtNeo/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtNeo/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtNeo/OnGetChartRasyo")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinanceHrtNeoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
