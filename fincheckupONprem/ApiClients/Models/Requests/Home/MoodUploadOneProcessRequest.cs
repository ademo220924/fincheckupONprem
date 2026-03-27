using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUploadOneProcessRequest
    {
        public XMlook PageIndex { get; set; }
    }

    public class MoodUploadOneProcessQuery
    {
        public MoodUploadOneProcessRequest Request { get; set; }
    }
}
