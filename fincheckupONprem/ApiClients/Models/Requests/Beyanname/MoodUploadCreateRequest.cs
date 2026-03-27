using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Beyanname;

public class MoodUploadCreateRequest
{
    public XMlook XMlook { get; set; }
}

public class MoodUploadCreateQuery
{
    public MoodUploadCreateRequest Request { get; set; }
}
