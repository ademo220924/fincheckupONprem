using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMainRequestInitialModel InitialModel { get; set; }
    }
}
