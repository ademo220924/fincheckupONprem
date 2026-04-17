using fincheckup.ApiClients.Models.Requests.Upload;
using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Upload;
public class UploadOnGetSalerMainNoteResponse
{
    public JsonElement? Result { get; set; }
    public UploadRequest InitialModel { get; set; }
}