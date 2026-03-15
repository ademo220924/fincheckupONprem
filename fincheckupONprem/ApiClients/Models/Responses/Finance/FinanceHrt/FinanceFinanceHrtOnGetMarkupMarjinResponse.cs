using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrt
{
    public class FinanceFinanceHrtOnGetMarkupMarjinResponse
    {
        public JsonResult Response { get; set; }
        public FinanceFinanceHrtRequestInitialModel InitialModel { get; set; }
    }
}
