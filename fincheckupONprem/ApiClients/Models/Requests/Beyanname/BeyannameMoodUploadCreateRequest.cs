using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Beyanname;

public class BeyannameMoodUploadCreateRequest
{
    public XMlook XMlook { get; set; }
}

public class BeyannameMoodUploadCreateQuery
{
    public BeyannameMoodUploadCreateRequest Request { get; set; }
}
