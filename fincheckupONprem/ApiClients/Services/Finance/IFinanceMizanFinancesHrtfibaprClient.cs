using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanFinancesHrtfibaprController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanFinancesHrtfibaprController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanFinancesHrtfibaprClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGet")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetResponse>> GetAsync([Body] MizanFinancesHrtfibaprOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGetMarkupMarjinC")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinCResponse>> GetMarkupMarjinCAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinCRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinancesHrtfibapr/OnGetChartRasyo")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinancesHrtfibaprOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
