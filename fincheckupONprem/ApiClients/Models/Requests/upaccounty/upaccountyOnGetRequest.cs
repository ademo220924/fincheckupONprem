
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.upaccounty;
public class UpaccountyOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}