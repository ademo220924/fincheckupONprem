using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Beyanname;

public class BeyannameMoodUploadUpdateRequest
{
    public XMlook XMlook { get; set; }
}

public class BeyannameMoodUploadUpdateQuery
{
    public BeyannameMoodUploadUpdateRequest Request { get; set; }
}
