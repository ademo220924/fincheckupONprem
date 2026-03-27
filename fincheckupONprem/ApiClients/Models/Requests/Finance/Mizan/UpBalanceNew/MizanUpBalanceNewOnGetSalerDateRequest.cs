using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }
    
     public class MizanUpBalanceNewOnGetSalerDateQuery 
     {
            [JsonIgnore] public  string UserId { get; set; }
            public MizanUpBalanceNewOnGetSalerDateRequest Request { get; set; }
            public MizanUpBalanceNewRequestInitialModel InitialModel { get; set; }
        }
}
