using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashRasyo;
using fincheckup.ApiClients.Models.Responses.DashRasyo;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashRasyoApiClient : IApiClientBase
{
    [Post("/api/dashrasyo/OnGet")]
    Task<GenericResult<DashRasyoOnGetResponse>> GetAsync([Body] DashRasyoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetCasino")]
    Task<GenericResult<DashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] DashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetChartRasyo")]
    Task<GenericResult<DashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetChartRasyoa")]
    Task<GenericResult<DashRasyoOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] DashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetChartRasyob")]
    Task<GenericResult<DashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] DashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetChartMali")]
    Task<GenericResult<DashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetChartLikid")]
    Task<GenericResult<DashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetDashRasyo")]
    Task<GenericResult<DashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetGraphYear")]
    Task<GenericResult<DashRasyoOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRasyoOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrasyo/OnGetGraphComp")]
    Task<GenericResult<DashRasyoOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRasyoOnGetGraphCompRequest request, CancellationToken cancellationToken);
}