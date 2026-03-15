
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.upchecky;
public class UpcheckyOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}