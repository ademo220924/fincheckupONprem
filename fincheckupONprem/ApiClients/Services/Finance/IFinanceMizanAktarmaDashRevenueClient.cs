using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanAktarmaDashRevenueController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanAktarmaDashRevenueController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanAktarmaDashRevenueClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashRevenue/OnGet")]
    Task<GenericResult<MizanAktarmaDashRevenueOnGetResponse>> GetAsync([Body] MizanAktarmaDashRevenueOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
