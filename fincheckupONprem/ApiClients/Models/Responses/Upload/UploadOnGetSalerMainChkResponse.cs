using fincheckup.ApiClients.Models.Requests.Upload;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.Upload;
public class UploadOnGetSalerMainChkResponse
{
    public JsonResult Result { get; set; }
    public UploadRequest InitialModel { get; set; }
}