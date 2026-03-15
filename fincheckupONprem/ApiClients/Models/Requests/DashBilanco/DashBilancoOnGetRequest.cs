
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.DashBilanco;
public class DashBilancoOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}