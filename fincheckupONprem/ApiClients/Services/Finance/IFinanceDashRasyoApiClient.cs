using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashRasyo;
using fincheckup.ApiClients.Models.Responses.Finance.DashRasyo;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashRasyoApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRasyo/OnGet")]
    Task<GenericResult<FinanceDashRasyoOnGetResponse>> GetAsync([Body] FinanceDashRasyoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetCasino")]
    Task<GenericResult<FinanceDashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] FinanceDashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyoa")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] FinanceDashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetChartRasyob")]
    Task<GenericResult<FinanceDashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] FinanceDashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetChartMali")]
    Task<GenericResult<FinanceDashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] FinanceDashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetChartLikid")]
    Task<GenericResult<FinanceDashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] FinanceDashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRasyo/OnGetDashRasyo")]
    Task<GenericResult<FinanceDashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] FinanceDashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken);
}