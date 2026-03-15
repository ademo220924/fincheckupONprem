using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashWorkingCapital;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashWorkingCapitalApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashWorkingCapital/OnGet")]
    Task<GenericResult<MizanDashWorkingCapitalOnGetResponse>> GetAsync([Body] MizanDashWorkingCapitalOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashWorkingCapital/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashWorkingCapitalOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashWorkingCapitalOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}