using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznOnGetSalerMainChkResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMznRequestInitialModel InitialModel { get; set; }
    }
}
