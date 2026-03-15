using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportPotDynamic;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportPotDynamic;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanReportPotDynamicApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/ReportPotDynamic/OnGet")]
    Task<GenericResult<MizanReportPotDynamicOnGetResponse>> GetAsync([Body] MizanReportPotDynamicOnGetRequest request, CancellationToken cancellationToken);
}