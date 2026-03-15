using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUpBalanceNewRequestInitialModel InitialModel { get; set; }
    }
}
