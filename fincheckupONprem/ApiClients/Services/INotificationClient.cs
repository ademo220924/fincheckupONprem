using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for NotificationController. Source: src/FinanceCheckUp.Api/Controllers/v1/NotificationController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface INotificationClient : IApiClientBase
{
    [Post("/api/notification/send-mail")]
    Task<GenericResult<HttpResponseMessage>> SendMailAsync([Body] SendMailRequest request, CancellationToken cancellationToken = default);
    [Post("/api/notification/send-mail-info")]
    Task<GenericResult<HttpResponseMessage>> SendMailInfoAsync([Body] SendMailRequest request, CancellationToken cancellationToken = default);
}
