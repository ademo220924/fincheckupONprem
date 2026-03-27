using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaMizan;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanJrnlUpPageAktarmaMizanController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanJrnlUpPageAktarmaMizanController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanJrnlUpPageAktarmaMizanClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaMizan/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaMizanOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaMizan/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaMizanOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaMizan/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaMizanOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaMizan/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaMizanOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaMizan/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaMizanOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
