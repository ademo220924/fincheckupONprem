using fincheckup.ApiClients.Models.Requests.Finance.UpBalance;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpBalanceRequestInitialModel InitialModel { get; set; }
    }
}
