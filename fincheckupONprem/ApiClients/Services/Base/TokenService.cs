namespace fincheckup.ApiClients.Services.Base;

public class TokenService
{
    private string _token;

    public void SetToken(string token)
    {
        _token = token;
    }

    public string GetToken()
    {
        return _token;
    }
}