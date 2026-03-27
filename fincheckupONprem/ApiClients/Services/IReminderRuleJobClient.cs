using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReminderRuleJobController. Source: src/FinanceCheckUp.Api/Controllers/v1/ReminderRuleJobController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReminderRuleJobClient : IApiClientBase
{
    [Get("/api/reminder-rule-job/id/{id:long}")]
    Task<GenericResult<ReminderRuleJobDto>> GetAsync(CancellationToken cancellationToken = default);
    [Get("/api/reminder-rule-job/company/id/{id:long}")]
    Task<GenericResult<List<ReminderRuleJobDto>>> GetListByCompanyAsync(CancellationToken cancellationToken = default);
    [Post("/api/reminder-rule-job/company-and-account")]
    Task<GenericResult<List<ReminderRuleJobDto>>> GetListByCompanyAndMainAccountIdAsync([Body] GetListByCompanyAndMainAccountIdRequest request, CancellationToken cancellationToken = default);
}
