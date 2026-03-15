using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Common;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface INotificationApiClient : IApiClientBase
{
    [Post("/api/notification/send-mail")]
    Task<GenericResult<HttpResponseMessage>> SendMailAsync([Body] SendMailRequest request,CancellationToken cancellationToken);

    [Post("/api/notification/send-mail-info")]
    Task<GenericResult<HttpResponseMessage>> SendMailInfoAsync( [Body] SendMailRequest request,CancellationToken cancellationToken);
}