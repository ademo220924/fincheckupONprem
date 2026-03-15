
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital
{
    public class MizanDashWorkingCapitalOnGetRequest
    {
        [JsonIgnore] public string UserId { get; set; }
    }
}
