using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtFiba;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanFinanceHrtFibaController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanFinanceHrtFibaController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanFinanceHrtFibaClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtFiba/OnGet")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetResponse>> GetAsync([Body] MizanFinanceHrtFibaOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtFiba/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtFiba/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtFiba/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtFiba/OnGetMarkupMarjinC")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinCResponse>> GetMarkupMarjinCAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinCRequest request, CancellationToken cancellationToken = default);
}
