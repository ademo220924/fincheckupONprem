using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Beyanname;

public class BeyannameMoodUploadCheckRequest
{
    public XMlook XMlook { get; set; }
}

public class BeyannameMoodUploadCheckQuery
{
    public BeyannameMoodUploadCheckRequest Request { get; set; }
}
