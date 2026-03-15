using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRasyo;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashRasyoApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashRasyo/OnGet")]
    Task<GenericResult<MizanDashRasyoOnGetResponse>> GetAsync([Body] MizanDashRasyoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetCasino")]
    Task<GenericResult<MizanDashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] MizanDashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetChartRasyo")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetChartRasyoa")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] MizanDashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetChartRasyob")]
    Task<GenericResult<MizanDashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] MizanDashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetChartMali")]
    Task<GenericResult<MizanDashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] MizanDashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetChartLikid")]
    Task<GenericResult<MizanDashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] MizanDashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRasyo/OnGetDashRasyo")]
    Task<GenericResult<MizanDashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] MizanDashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken);
}