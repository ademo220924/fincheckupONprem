
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}