using System.Collections.Generic;
using fincheckup.ApiClients.Entities.BgServer.Dtos.BgServer.Rules;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReminderRuleController. Source: src/FinanceCheckUp.Api/Controllers/v1/ReminderRuleController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReminderRuleClient : IApiClientBase
{
    [Get("/api/reminder-rule")]
    Task<GenericResult<List<RemainderRuleDto>>> GetListAsync(CancellationToken cancellationToken = default);

    [Get("/api/reminder-rule/id/{id}")]
    Task<GenericResult<RemainderRuleDto>> GetAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken = default);

    [Get("/api/reminder-rule/period-type/{periodType}")]
    Task<GenericResult<List<RemainderRuleDto>>> GetListByPeriodTypeAsync(
        [AliasAs("periodType")] fincheckup.ApiClients.Models.Common.PeriodType periodType,
        CancellationToken cancellationToken = default);
}
