using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMzan
{
    public class MizanUploadMzanOnGetSalerMainChkResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMzanRequestInitialModel InitialModel { get; set; }
    }
}
