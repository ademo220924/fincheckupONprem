using fincheckup.ApiClients.Models.Requests.Finance.Upload;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerMainZetaResponse
    {
        public JsonResult Response { get; set; }
        public FinanceUploadMainRequestInitialModel InitialModel { get; set; }
    }
}
