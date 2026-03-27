using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.Models.EarlyWarning.Response;
using fincheckup.ApiClients.Models.Requests.Reminder.Account;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IReminderAccountApiClient : IApiClientBase
{
    [Get("/api/reminder-account")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListAsync(
        CancellationToken cancellationToken);

    [Get("/api/reminder-account/id/{id}")]
    Task<GenericResult<ReminderAccountDto>> GetAsync(
        [AliasAs("id")] long id,
        CancellationToken cancellationToken);

    [Get("/api/reminder-account/account-group/id/{accountGroupId}")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListByAccountGroupAsync(
        [AliasAs("accountGroupId")] int accountGroupId,
        CancellationToken cancellationToken);

    [Get("/api/reminder-account/account-type/{accountType}")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListByPaymentTypeAsync(
        [AliasAs("accountType")] fincheckup.Models.EarlyWarning.Response.AccountType accountType,
        CancellationToken cancellationToken);

    [Post("/api/reminder-account")]
    Task<GenericResult<ReminderAccountDto>> CreateAsync(
        [Body] ReminderAccountCreateRequest command,
        CancellationToken cancellationToken);

    [Put("/api/reminder-account")]
    Task<GenericResult<ReminderAccountDto>> UpdateAsync(
        [Body] ReminderAccountUpdateRequest command,
        CancellationToken cancellationToken);
}