
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetCheckRepPdfRequest
    {
        public long companyID { get; set; }
        public int nyear { get; set; }
    }
    
    public class MizanUpBalanceNewOnGetCheckRepPdfQuery
    {
        public MizanUpBalanceNewOnGetCheckRepPdfRequest Request { get; set; }
    }
}
