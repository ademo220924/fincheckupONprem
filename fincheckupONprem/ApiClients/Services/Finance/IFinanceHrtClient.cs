using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceHrtController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceHrtController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceHrtClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrt/OnGet")]
    Task<GenericResult<FinanceFinanceHrtOnGetResponse>> GetAsync([Body] FinanceFinanceHrtOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrt/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
}
