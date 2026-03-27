using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadNwMizanRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadNwMizanQuery
    {
        public MoodUploadNwMizanRequest Request { get; set; }
    }
}
