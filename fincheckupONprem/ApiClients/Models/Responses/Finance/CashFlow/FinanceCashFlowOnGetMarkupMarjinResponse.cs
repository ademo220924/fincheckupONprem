using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.CashFlow
{
    public class FinanceCashFlowOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public FinanceCashFlowRequestInitialModel InitialModel { get; set; }
    }
}
