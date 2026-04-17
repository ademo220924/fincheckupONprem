
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetCheckRepPdfRequest
    {
        public long companyID { get; set; }
        public int nyear { get; set; }
    }
    
    public class MizanUpBalanceNewOnGetCheckRepPdfQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanUpBalanceNewOnGetCheckRepPdfRequest Request { get; set; }
        public MizanUpBalanceNewRequestInitialModel InitialModel { get; set; }
    }
}
