
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetRequest
    {
        [JsonIgnore] public string UserId { get; set; }
    }

    public class MizanUpBalanceOnGetQuery
    {
        public MizanUpBalanceOnGetRequest Request { get; set; }
    }
}
