using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateAccountCheckRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateAccountCheckQuery
    {
        public MoodUpdateAccountCheckRequest Request { get; set; }
    }
}
