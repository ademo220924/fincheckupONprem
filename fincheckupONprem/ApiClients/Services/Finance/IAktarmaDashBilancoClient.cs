using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for AktarmaDashBilancoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanAktarmaDashBilancoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IAktarmaDashBilancoClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/AktarmaDashBilanco/OnGet")]
    Task<GenericResult<MizanAktarmaDashBilancoOnGetResponse>> GetAsync([Body] MizanAktarmaDashBilancoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/aktarma/AktarmaDashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashBilancoOnGetMarkupMarjinQuery request, CancellationToken cancellationToken = default);
}
