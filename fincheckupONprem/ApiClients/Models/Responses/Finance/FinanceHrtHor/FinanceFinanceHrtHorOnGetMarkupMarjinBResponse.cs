using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtHor
{
    public class FinanceFinanceHrtHorOnGetMarkupMarjinBResponse
    {
        public JsonResult Response { get; set; }
        public FinanceFinanceHrtHorRequestInitialModel InitialModel { get; set; }
    }
}
