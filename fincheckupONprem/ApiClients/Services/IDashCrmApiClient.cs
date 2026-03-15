using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.DashCrm;
using fincheckup.ApiClients.Models.Requests.DashCrm;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCrmApiClient : IApiClientBase
{
    [Post("/api/dashcrm/OnGet")]
    Task<GenericResult<DashCrmOnGetResponse>> GetAsync([Body] DashCrmOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetCasino")]
    Task<GenericResult<DashCrmOnGetCasinoResponse>> GetCasinoAsync([Body] DashCrmOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetRasyo")]
    Task<GenericResult<DashCrmOnGetChartRasyoResponse>> GetRasyoAsync([Body] DashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetRasyoa")]
    Task<GenericResult<DashCrmOnGetChartRasyoaResponse>> GetRasyoaAsync([Body] DashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetRasyob")]
    Task<GenericResult<DashCrmOnGetChartRasyobResponse>> GetRasyobAsync([Body] DashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetRasyod")]
    Task<GenericResult<DashCrmOnGetChartRasyodResponse>> GetRasyodAsync([Body] DashCrmOnGetChartRasyodRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetRasyoc")]
    Task<GenericResult<DashCrmOnGetChartRasyocResponse>> GetRasyocAsync([Body] DashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetChartMali")]
    Task<GenericResult<DashCrmOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashCrmOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetChartLikid")]
    Task<GenericResult<DashCrmOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashCrmOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetDashRasyo")]
    Task<GenericResult<DashCrmOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashCrmOnGetDashRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetGraphYear")]
    Task<GenericResult<DashCrmOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrm/OnGetGraphComp")]
    Task<GenericResult<DashCrmOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmOnGetGraphCompRequest request, CancellationToken cancellationToken);
}
