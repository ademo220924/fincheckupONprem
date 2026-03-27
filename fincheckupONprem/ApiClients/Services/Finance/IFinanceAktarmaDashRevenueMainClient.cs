using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenueMain;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashRevenueMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceAktarmaDashRevenueMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceAktarmaDashRevenueMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceAktarmaDashRevenueMainClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGet")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetResponse>> GetAsync([Body] AktarmaDashRevenueMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashRevenueMainOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashRevenueMainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
