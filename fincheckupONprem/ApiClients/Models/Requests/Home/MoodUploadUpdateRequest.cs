using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadUpdateRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadUpdateQuery
    {
        public MoodUploadUpdateRequest Request { get; set; }
    }
}
