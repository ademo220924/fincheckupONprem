using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanFinanceHrtController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanFinanceHrtController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanFinanceHrtClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanFinanceHrt/OnGet")]
    Task<GenericResult<MizanFinanceHrtOnGetResponse>> GetAsync([Body] MizanFinanceHrtOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrt/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrt/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrt/OnGetChartRasyo")]
    Task<GenericResult<MizanFinanceHrtOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinanceHrtOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
