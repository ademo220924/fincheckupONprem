using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using fincheckup.ApiClients.Models.Responses.Finance.DashBilancoJrnl;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashBilancoJrnlApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashBilancoJrnl/OnGet")]
    Task<GenericResult<FinanceDashBilancoJrnlOnGetResponse>> GetAsync([Body] FinanceDashBilancoJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashBilancoJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceDashBilancoJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceDashBilancoJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}