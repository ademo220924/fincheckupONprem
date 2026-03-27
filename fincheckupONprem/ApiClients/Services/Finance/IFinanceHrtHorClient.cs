using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceHrtHorController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceHrtHorController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceHrtHorClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrtHor/OnGet")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetResponse>> GetAsync([Body] FinanceFinanceHrtHorOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtHor/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtHorOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinARequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken = default);
}
