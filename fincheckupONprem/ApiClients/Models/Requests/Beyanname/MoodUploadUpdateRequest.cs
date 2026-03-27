using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Beyanname;

public class MoodUploadUpdateRequest
{
    public XMlook XMlook { get; set; }
}

public class MoodUploadUpdateQuery
{
    public MoodUploadUpdateRequest Request { get; set; }
}
