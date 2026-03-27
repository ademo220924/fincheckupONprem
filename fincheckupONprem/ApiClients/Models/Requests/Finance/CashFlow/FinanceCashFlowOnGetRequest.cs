
using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;

namespace fincheckup.ApiClients.Models.Requests.Finance.CashFlow
{
    public class FinanceCashFlowOnGetRequest
    {
        public FinanceCashFlowRequestInitialModel Request { get; set; }
    }

    public class FinanceCashFlowOnGetQuery
    {
        public FinanceCashFlowOnGetRequest Request { get; set; }
    }
}
