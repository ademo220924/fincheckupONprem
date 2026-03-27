using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashCrmController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashCrmController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashCrmClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashCrm/OnGet")]
    Task<GenericResult<MizanDashCrmOnGetResponse>> GetAsync([Body] MizanDashCrmOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashCrm/OnGetChartRasyo")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyoResponse>> GetOnGetChartRasyoAsync([Body] MizanDashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashCrm/OnGetChartRasyoa")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] MizanDashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashCrm/OnGetChartRasyob")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] MizanDashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashCrm/OnGetChartRasyoc")]
    Task<GenericResult<MizanDashCrmOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] MizanDashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken = default);
}
