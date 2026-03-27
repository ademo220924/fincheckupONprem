using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashCompare;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanAktarmaDashCompareController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanAktarmaDashCompareController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanAktarmaDashCompareClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashCompare/OnGet")]
    Task<GenericResult<MizanAktarmaDashCompareOnGetResponse>> GetAsync([Body] MizanAktarmaDashCompareOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashCompare/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashCompareOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashCompareOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
