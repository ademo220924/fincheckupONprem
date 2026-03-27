using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.Reminder;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Entities.BgServer.Dtos.BgServer.Rules;

namespace fincheckup.ApiClients.Services;

public interface IReminderRuleApiClient : IApiClientBase
{
    [Get("/api/reminder-rule")]
    Task<GenericResult<List<RemainderRuleDto>>> GetListAsync(CancellationToken cancellationToken);

    [Get("/api/reminder-rule/id/{id}")]
    Task<GenericResult<RemainderRuleDto>> GetAsync([AliasAs("id")] long id,CancellationToken cancellationToken);

    [Get("/api/reminder-rule/period-type/{periodType}")]
    Task<GenericResult<List<RemainderRuleDto>>> GetListByPeriodTypeAsync([AliasAs("periodType")] fincheckup.ApiClients.Models.Common.PeriodType periodType,CancellationToken cancellationToken);

    [Post("/api/reminder-rule/create")]
    Task<GenericResult<RemainderRuleDto>> CreateAsync([Body] CreateRemainderRuleRequest command,  CancellationToken cancellationToken);

    [Post("/api/reminder-rule/generate")]
    Task<GenericResult<RemainderRuleDto>> GenerateAsync([Body] GenerateRemainderRuleRequest command,CancellationToken cancellationToken);
}