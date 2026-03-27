namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class CreateAccountGroupRequest
{
    public string Name { get; set; }

    public class CreateAccountGroupQuery
    {
        public CreateAccountGroupRequest Request { get; set; }
    }
}
