using System.Text.Json.Serialization;
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }
    
    public class MizanUpBalanceNewOnGetSalerYearQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanUpBalanceNewOnGetSalerYearRequest Request {  get; set; }
    }
}
