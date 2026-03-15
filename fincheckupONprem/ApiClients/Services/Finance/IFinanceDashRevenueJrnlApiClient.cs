using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl;
using fincheckup.ApiClients.Models.Responses.Finance.DashRevenueJrnl;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashRevenueJrnlApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRevenueJrnl/OnGet")]
    Task<GenericResult<FinanceDashRevenueJrnlOnGetResponse>> GetAsync([Body] FinanceDashRevenueJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRevenueJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceDashRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceDashRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}