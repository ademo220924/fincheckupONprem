using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Entities.BgServer;
using fincheckup.ApiClients.Entities.BgServer.Dtos.BgServer.AccountGroups;
using fincheckup.ApiClients.Models.Requests.Reminder;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReminderAccountGroupController. Source: src/FinanceCheckUp.Api/Controllers/v1/ReminderAccountGroupController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReminderAccountGroupClient : IApiClientBase
{
    [Get("/api/reminder-account-group")]
    Task<GenericResult<List<ReminderAccountGroup>>> GetListAsync(CancellationToken cancellationToken = default);

    [Get("/api/reminder-account-group/id/{id}")]
    Task<GenericResult<ReminderAccountGroupDto>> GetAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken = default);

    [Post("/api/reminder-account-group")]
    Task<GenericResult<ReminderAccountGroupDto>> CreateAsync(
        [Body] CreateAccountGroupRequest command,
        CancellationToken cancellationToken = default);

    [Put("/api/reminder-account-group")]
    Task<GenericResult<ReminderAccountGroupDto>> UpdateAsync(
        [Body] UpdateAccountGroupRequest command,
        CancellationToken cancellationToken = default);
}
