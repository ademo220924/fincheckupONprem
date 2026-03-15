using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrm;
using fincheckup.ApiClients.Models.Responses.Finance.DashCrm;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashCrmApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrm/OnGet")]
    Task<GenericResult<FinanceDashCrmOnGetResponse>> GetAsync([Body] FinanceDashCrmOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetCasino")]
    Task<GenericResult<FinanceDashCrmOnGetCasinoResponse>> GetCasinoAsync([Body] FinanceDashCrmOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyoa")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyoaResponse>> GetChartRasyoaAsync([Body] FinanceDashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyob")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] FinanceDashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartRasyoc")]
    Task<GenericResult<FinanceDashCrmOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] FinanceDashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartMali")]
    Task<GenericResult<FinanceDashCrmOnGetChartMaliResponse>> GetChartMaliAsync([Body] FinanceDashCrmOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetChartLikid")]
    Task<GenericResult<FinanceDashCrmOnGetChartLikidResponse>> GetChartLikidAsync([Body] FinanceDashCrmOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrm/OnGetDashRasyo")]
    Task<GenericResult<FinanceDashCrmOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] FinanceDashCrmOnGetDashRasyoRequest request, CancellationToken cancellationToken);
}