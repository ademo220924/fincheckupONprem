using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanJrnlUpPageAktarmaJrnlApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateMainRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetSalerDateCode")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateCodeResponse>> GetSalerDateCodeAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateCodeRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetGraphCode")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetGraphCodeResponse>> GetGraphCodeAsync([Body] MizanUpPageAktarmaJrnlOnGetGraphCodeRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaJrnl/OnGetGraphCodeDel")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetGraphCodeDelResponse>> GetGraphCodeDelAsync([Body] MizanUpPageAktarmaJrnlOnGetGraphCodeDelRequest request, CancellationToken cancellationToken);
}