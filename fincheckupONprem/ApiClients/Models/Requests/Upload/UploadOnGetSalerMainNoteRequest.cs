
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetSalerMainNoteRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class UploadOnGetSalerMainNoteQuery
{
    public UploadOnGetSalerMainNoteRequest Request { get; set; }
}
