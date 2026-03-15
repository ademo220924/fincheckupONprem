using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznMlt
{
    public class MizanUploadMznMltOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadMznMltRequestInitialModel InitialModel { get; set; }
    }
}
