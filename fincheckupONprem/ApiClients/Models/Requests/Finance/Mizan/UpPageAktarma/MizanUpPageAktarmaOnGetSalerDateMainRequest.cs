
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerDateMainRequest
    {
        public int nyear { get; set; }
        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }

    public class MizanUpPageAktarmaOnGetSalerDateMainQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanUpPageAktarmaOnGetSalerDateMainRequest Request { get; set; }
        
      
    }
}
