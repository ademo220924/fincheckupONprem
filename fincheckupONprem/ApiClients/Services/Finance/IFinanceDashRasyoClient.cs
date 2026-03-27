using fincheckup.ApiClients.Models.Requests.Finance.DashRasyo;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashRasyoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashRasyoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashRasyoClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRasyo/OnGet")]
    Task<GenericResult<FinanceDashRasyoOnGetResponse>> GetAsync([Body] FinanceDashRasyoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetCasino")]
    Task<GenericResult<FinanceDashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] FinanceDashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyoa")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] FinanceDashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyob")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] FinanceDashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetChartMali")]
    Task<GenericResult<FinanceDashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] FinanceDashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetChartLikid")]
    Task<GenericResult<FinanceDashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] FinanceDashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRasyo/OnGetDashRasyo")]
    Task<GenericResult<FinanceDashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] FinanceDashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
}
