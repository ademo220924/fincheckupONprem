using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMzn;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadMznApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGet")]
    Task<GenericResult<MizanUploadMznOnGetResponse>> GetAsync([Body] MizanUploadMznOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMznOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMznOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMznOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMznOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMznOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMznOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMznOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMznOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMznOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMznOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}