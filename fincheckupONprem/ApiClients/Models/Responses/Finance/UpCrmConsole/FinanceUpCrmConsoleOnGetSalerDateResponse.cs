using fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.UpCrmConsole
{
    public class FinanceUpCrmConsoleOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUpCrmConsoleRequestInitialModel InitialModel { get; set; }
    }
}
