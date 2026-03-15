using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadMainApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGet")]
    Task<GenericResult<MizanUploadMainOnGetResponse>> GetAsync([Body] MizanUploadMainOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMainOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMainOnGetSalerMainChkRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMainOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMainOnGetSalerMainZetaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMainOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMainOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMainOnGetSalerCompRequest request, CancellationToken cancellationToken);
}