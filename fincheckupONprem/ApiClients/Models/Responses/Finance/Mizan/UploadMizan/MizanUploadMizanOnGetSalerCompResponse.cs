using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerCompResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMizanRequestInitialModel InitialModel { get; set; }
    }
}
