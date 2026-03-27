using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashRasyoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashRasyoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashRasyoClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGet")]
    Task<GenericResult<MizanDashRasyoOnGetResponse>> GetAsync([Body] MizanDashRasyoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetCasino")]
    Task<GenericResult<MizanDashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] MizanDashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetChartRasyo")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetChartRasyoa")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] MizanDashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetChartRasyob")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] MizanDashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetChartMali")]
    Task<GenericResult<MizanDashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] MizanDashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetChartLikid")]
    Task<GenericResult<MizanDashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] MizanDashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRasyo/OnGetDashRasyo")]
    Task<GenericResult<MizanDashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] MizanDashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
}
