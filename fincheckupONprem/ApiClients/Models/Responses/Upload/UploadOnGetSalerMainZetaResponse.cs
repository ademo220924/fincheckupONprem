using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.Upload;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.Upload;
public class UploadOnGetSalerMainZetaResponse
{
    public LoadResult Result { get; set; }
    public UploadRequest InitialModel { get; internal set; }
}