using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadOneGoOnRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadOneGoOnQuery
    {
        public MoodUploadOneGoOnRequest Request { get; set; }
    }
}
