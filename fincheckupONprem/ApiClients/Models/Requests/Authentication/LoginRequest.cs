namespace fincheckup.ApiClients.Models.Requests.Authentication;

public class LoginRequest
{
    public string MailAddress { get; internal set; }
    public string Password { get; internal set; }

    public class LoginQuery
    {
        public LoginRequest Request { get; set; }
    }
}
