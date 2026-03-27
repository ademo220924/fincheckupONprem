
namespace fincheckup.ApiClients.Models.Requests.Finance.CashFlow
{
    public class FinanceCashFlowOnGetGraphYearRequest
    {
        public int nyear {  get; set; }
    }

    public class FinanceCashFlowOnGetGraphYearQuery
    {
        public FinanceCashFlowOnGetGraphYearRequest Request { get; set; }
    }
}
