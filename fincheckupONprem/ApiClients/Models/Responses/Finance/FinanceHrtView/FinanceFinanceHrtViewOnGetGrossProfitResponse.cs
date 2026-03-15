using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtView
{
    public class FinanceFinanceHrtViewOnGetGrossProfitResponse
    {
        public JsonResult Response { get; set; }
        public FinanceFinanceHrtViewRequestInitialModel InitialModel { get; set; }
    }
}
