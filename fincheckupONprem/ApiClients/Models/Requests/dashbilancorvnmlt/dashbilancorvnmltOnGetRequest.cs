
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.dashbilancorvnmlt;
public class DashbilancorvnmltOnGetRequest
{
    [JsonIgnore] public string UserId { get; set; }
}

public class DashbilancorvnmltOnGetQuery
{
    public DashbilancorvnmltOnGetRequest Request { get; set; }
}
