using fincheckup.ApiClients.Models.Requests.Finance.DashCrm;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashCrmController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashCrmController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashCrmClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrm/OnGet")]
    Task<GenericResult<FinanceDashCrmOnGetResponse>> GetAsync([Body] FinanceDashCrmOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetCasino")]
    Task<GenericResult<FinanceDashCrmOnGetCasinoResponse>> GetCasinoAsync([Body] FinanceDashCrmOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyoResponse>> GetOnGetChartRasyoAsync([Body] FinanceDashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyoa")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] FinanceDashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyob")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] FinanceDashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyoc")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] FinanceDashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartMali")]
    Task<GenericResult<FinanceDashCrmOnGetChartMaliResponse>> GetChartMaliAsync([Body] FinanceDashCrmOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetChartLikid")]
    Task<GenericResult<FinanceDashCrmOnGetChartLikidResponse>> GetChartLikidAsync([Body] FinanceDashCrmOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrm/OnGetDashRasyo")]
    Task<GenericResult<FinanceDashCrmOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] FinanceDashCrmOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
}
