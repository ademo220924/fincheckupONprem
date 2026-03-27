
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class ChangePasswordOnGetQuery
{
    public ChangePasswordOnGetRequest Request { get; set; }
}
