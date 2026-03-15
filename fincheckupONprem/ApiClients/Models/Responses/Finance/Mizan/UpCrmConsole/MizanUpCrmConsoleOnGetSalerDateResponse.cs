using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpCrmConsole;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpCrmConsole
{
    public class MizanUpCrmConsoleOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpCrmConsoleRequestInitialModel InitialModel { get; set; }
    }
}
