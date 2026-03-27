using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceUpPageAktarmaMznController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUpPageAktarmaMznController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceUpPageAktarmaMznClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGet")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetResponse>> GetAsync([Body] FinanceUpPageAktarmaMznOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerDateMain")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] FinanceUpPageAktarmaMznOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerDate")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpPageAktarmaMznOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerYear")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpPageAktarmaMznOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerComp")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpPageAktarmaMznOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
