using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Users;

public class UserPasswordChangeRequest
{
    public int Id { get; set; }
    public string Password { get; set; }

    [JsonIgnore] public string UserId { get; set; }
}

public class UserPasswordChangeQuery
{
    public UserPasswordChangeRequest Request { get; set; }
}
