using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.Reminder;
using fincheckup.ApiClients.Entities.BgServer;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IReminderRuleJobApiClient : IApiClientBase
{
    [Get("/api/reminder-rule-job/id/{id}")]
    Task<GenericResult<ReminderRuleJob>> GetAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken);

    [Get("/api/reminder-rule-job/company/id/{id}")]
    Task<GenericResult<List<ReminderRuleJob>>> GetListByCompanyAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken);

    [Post("/api/reminder-rule-job/company-and-account")]
    Task<GenericResult<List<ReminderRuleJob>>> GetListByCompanyAndMainAccountIdAsync(
        [Body] GetListByCompanyAndMainAccountIdRequest request,
        CancellationToken cancellationToken);

    [Post("/api/reminder-rule-job/create")]
    Task<GenericResult<ReminderRuleJob>> CreateAsync(
        [Body] CreateRemainderRuleJobRequest command,
        CancellationToken cancellationToken);
}