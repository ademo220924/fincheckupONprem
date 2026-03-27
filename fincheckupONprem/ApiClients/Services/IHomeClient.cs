using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for HomeController (no HTTP actions found). Source: src/FinanceCheckUp.Api/Controllers/v1/HomeController.cs
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IHomeClient : IApiClientBase
{
}
