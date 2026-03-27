
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo
{
    public class FinanceHrtNeoOnGetRequest
    {
        public MizanFinanceHrtNeoRequestInitialModel RequestInitialModel { get; set; }
    }

    public class FinanceHrtNeoOnGetQuery
    {
        public FinanceHrtNeoOnGetRequest Request { get; set; }
    }
}
