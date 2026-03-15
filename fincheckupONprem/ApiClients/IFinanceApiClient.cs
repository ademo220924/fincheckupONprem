using fincheckup.ApiClients.Services;

namespace fincheckup.ApiClients;

public interface IFinanceApiClient : IAuthenticationApiClient, IBeyannameApiClient, IBultenApiClient, ICashFlowApiClient, IChangePasswordApiClient
{
}
