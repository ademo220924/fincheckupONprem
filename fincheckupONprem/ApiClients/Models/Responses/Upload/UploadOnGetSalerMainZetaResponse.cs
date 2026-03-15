using fincheckup.ApiClients.Models.Requests.Upload;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.Upload;
public class UploadOnGetSalerMainZetaResponse
{
    public JsonResult Result { get; set; }
    public UploadRequest InitialModel { get; internal set; }
}