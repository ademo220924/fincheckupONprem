using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtNeo
{
    public class FinanceFinanceHrtNeoOnGetMarkupMarjinAResponse
    {
        public JsonResult Response { get; set; }
        public FinanceFinanceHrtNeoRequestInitialModel InitialModel { get; set; }
    }
}
