using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Entities.BgServer;
using fincheckup.ApiClients.Models.Requests.Reminder;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IReminderAccountGroupApiClient : IApiClientBase
{
    [Get("/api/reminder-account-group")]
    Task<GenericResult<List<ReminderAccountGroup>>> GetListAsync(
        CancellationToken cancellationToken);

    [Get("/api/reminder-account-group/id/{id}")]
    Task<GenericResult<ReminderAccountGroupDto>> GetAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken);

    [Post("/api/reminder-account-group")]
    Task<GenericResult<ReminderAccountGroupDto>> CreateAsync(
        [Body] CreateAccountGroupRequest command,
        CancellationToken cancellationToken);

    [Put("/api/reminder-account-group")]
    Task<GenericResult<ReminderAccountGroupDto>> UpdateAsync(
        [Body] UpdateAccountGroupRequest command,
        CancellationToken cancellationToken);
}