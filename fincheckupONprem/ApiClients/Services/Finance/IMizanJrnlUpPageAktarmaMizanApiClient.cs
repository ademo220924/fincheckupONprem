using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanJrnlUpPageAktarmaMizanApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/UpPageAktarmaMizan/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaMizanOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaMizan/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaMizanOnGetSalerDateMainRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaMizan/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaMizanOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaMizan/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaMizanOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/UpPageAktarmaMizan/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaMizanOnGetSalerCompRequest request, CancellationToken cancellationToken);
}