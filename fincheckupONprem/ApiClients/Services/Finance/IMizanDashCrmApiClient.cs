using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashCrm;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashCrmApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashCrm/OnGet")]
    Task<GenericResult<MizanDashCrmOnGetResponse>> GetAsync([Body] MizanDashCrmOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashCrm/OnGetChartRasyo")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashCrm/OnGetChartRasyoa")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] MizanDashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashCrm/OnGetChartRasyob")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] MizanDashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashCrm/OnGetChartRasyoc")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] MizanDashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken);
}