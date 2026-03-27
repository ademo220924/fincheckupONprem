using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceAktarmaDashRevenueController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceAktarmaDashRevenueController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceAktarmaDashRevenueClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGet")]
    Task<GenericResult<AktarmaDashRevenueOnGetResponse>> GetAsync([Body] AktarmaDashRevenueOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashRevenueOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashRevenueOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
