using fincheckup.ApiClients.Models.Requests.Finance.UpBalance;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetCheckRepPdfResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpBalanceRequestInitialModel InitialModel { get; set; }
    }
}
