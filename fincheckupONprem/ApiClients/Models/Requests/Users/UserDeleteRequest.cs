using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Users;

public class UserDeleteRequest
{
    [JsonIgnore] public string UserId { get; set; }
    public long Id { get; set; }
}