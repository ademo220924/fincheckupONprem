using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReminderAccountController. Source: src/FinanceCheckUp.Api/Controllers/v1/ReminderAccountController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReminderAccountClient : IApiClientBase
{
    [Get("/api/reminder-account")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListAsync(CancellationToken cancellationToken = default);
    [Get("/api/reminder-account/id/{id:long}")]
    Task<GenericResult<ReminderAccountDto>> GetAsync(CancellationToken cancellationToken = default);
    [Get("/api/reminder-account/account-group/id/{accountGroupId:long}")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListByAccountGroupAsync(CancellationToken cancellationToken = default);
    [Get("/api/reminder-account/account-type/{accountType}")]
    Task<GenericResult<List<ReminderAccountDto>>> GetListByPaymentTypeAsync(CancellationToken cancellationToken = default);
    [Post("/api/reminder-account")]
    Task<GenericResult<ReminderAccountDto>> CreateAsync([Body] ReminderAccountCreateRequest request, CancellationToken cancellationToken = default);
    [Put("/api/reminder-account")]
    Task<GenericResult<ReminderAccountDto>> UpdateAsync([Body] ReminderAccountUpdateRequest request, CancellationToken cancellationToken = default);
}
