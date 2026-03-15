
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.upbalancey;
public class UpbalanceyOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}