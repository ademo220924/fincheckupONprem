using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportBalance;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportBalance;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit; 

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanReportBalanceApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/ReportBalance/OnGet")]
    Task<GenericResult<MizanReportBalanceOnGetResponse>> GetAsync([Body] MizanReportBalanceOnGetRequest request, CancellationToken cancellationToken);
}