
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl
{
    public class MizanUpPageAktarmaJrnlOnGetRequest
    {
        [JsonIgnore] public string UserId { get; set; } 
    }

    public class MizanUpPageAktarmaJrnlOnGetQuery
    {
        public MizanUpPageAktarmaJrnlOnGetRequest Request { get; set; }
    }
}
