using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance
{
    public class MizanUpBalanceOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpBalanceRequestInitialModel InitialModel { get; set; }
    }
}
