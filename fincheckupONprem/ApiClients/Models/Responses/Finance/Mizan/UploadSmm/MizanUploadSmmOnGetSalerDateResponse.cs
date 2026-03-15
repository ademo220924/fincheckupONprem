using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmOnGetSalerDateResponse
    {
        public JsonResult Response { get; set; }
        public MizanUploadSmmRequestInitialModel InitialModel { get; set; }
    }
}
