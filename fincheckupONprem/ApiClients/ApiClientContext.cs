using fincheckup.ApiClients.Services;
using System;
using System.Collections.Generic;

namespace fincheckup.ApiClients;


public interface IApiClientContext
{
    public IAuthenticationApiClient AuthenticationApiClient => GetApiClient<IAuthenticationApiClient>();
    public IBeyannameApiClient BeyannameApiClient => GetApiClient<IBeyannameApiClient>();
    public IBultenApiClient BultenApiClient => GetApiClient<IBultenApiClient>();
    public ICashFlowApiClient CashFlowApiClient => GetApiClient<ICashFlowApiClient>();
    public IChangePasswordApiClient ChangePasswordApiClient => GetApiClient<IChangePasswordApiClient>();
    public IHomeApiCLient HomeApiClient => GetApiClient<IHomeApiCLient>();
    TApiCLient GetApiClient<TApiCLient>(); //where TApiCLient : class;

    object GetApiClient(Type target);
}


public class ApiClientContext(IServiceProvider serviceProvider) : IApiClientContext
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly Dictionary<Type, object> _localApiClients = [];

    public TApiCLient GetApiClient<TApiCLient>() //where TApiCLient : Interface
    {
        var target = typeof(TApiCLient);
        return (TApiCLient)GetApiClient(target);
    }

    public object GetApiClient(Type target)
    {
        if (_localApiClients.TryGetValue(target, out var ApiClient))
            return ApiClient; 
        ApiClient = _serviceProvider.GetService(target);
        _localApiClients.Add(target, ApiClient);
        return ApiClient;
    }
}
