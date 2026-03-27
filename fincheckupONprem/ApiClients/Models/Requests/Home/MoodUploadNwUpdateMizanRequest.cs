using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadNwUpdateMizanRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadNwUpdateMizanQuery
    {
        public MoodUploadNwUpdateMizanRequest Request { get; set; }
    }
}
