
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.CashFlow
{
    public class MizanCashFlowOnGetGraphYearRequest
    {
        public int nyear {  get; set; }
    }

    public class MizanCashFlowOnGetGraphYearQuery
    {
        public MizanCashFlowOnGetGraphYearRequest Request { get; set; }
    }
}
