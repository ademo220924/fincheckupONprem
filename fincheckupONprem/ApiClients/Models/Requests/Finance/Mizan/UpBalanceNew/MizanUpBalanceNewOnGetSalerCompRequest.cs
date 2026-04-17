using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }
    
    public class MizanUpBalanceNewOnGetSalerCompQuery
    {
        public MizanUpBalanceNewOnGetSalerCompRequest Request { get; set; }
        [JsonIgnore] public  string UserId { get; set; }
    }
}
