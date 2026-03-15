
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetRequest
    {
        [JsonIgnore] public string UserId { get; set; }
        
    }
}
