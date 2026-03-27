using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadOneUpdateRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadOneUpdateQuery
    {
        public MoodUploadOneUpdateRequest Request { get; set; }
    }
}
