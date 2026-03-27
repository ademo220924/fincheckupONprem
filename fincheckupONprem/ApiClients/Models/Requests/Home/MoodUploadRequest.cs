using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadQuery
    {
        public MoodUploadRequest Request { get; set; }
    }
}
