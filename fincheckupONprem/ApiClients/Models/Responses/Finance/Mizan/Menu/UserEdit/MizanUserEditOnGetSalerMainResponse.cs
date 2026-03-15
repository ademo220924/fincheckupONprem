using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetSalerMainResponse
    {
        public JsonResult Response { get; set; }
        public MizanUserEditRequestInitialModel InitialModel { get; set; }
    }
}
