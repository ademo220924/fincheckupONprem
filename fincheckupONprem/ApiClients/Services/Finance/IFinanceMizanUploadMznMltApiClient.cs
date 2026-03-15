using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznMlt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadMznMltApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGet")]
    Task<GenericResult<MizanUploadMznMltOnGetResponse>> GetAsync([Body] MizanUploadMznMltOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMznMltOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMznMltOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMznMltOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}