
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetGraphYearRequest
    {
        public int nyear {  get; set; }
    }

    public class MizanUpBalanceOnGetGraphYearQuery
    {
        public MizanUpBalanceOnGetGraphYearRequest Request { get; set; }
    }
}
