using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Mizan
{
    public class MoodUpdateSaktarmaSelectedRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateSaktarmaSelectedQuery
    {
        public MoodUpdateSaktarmaSelectedRequest Request { get; set; }
    }
}
