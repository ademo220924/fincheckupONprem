using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateQuery
    {
        public MoodUpdateRequest Request { get; set; }
    }
}
