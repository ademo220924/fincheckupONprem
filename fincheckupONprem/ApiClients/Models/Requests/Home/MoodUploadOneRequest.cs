using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadOneRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadOneQuery
    {
        public MoodUploadOneRequest Request { get; set; }
    }
}
