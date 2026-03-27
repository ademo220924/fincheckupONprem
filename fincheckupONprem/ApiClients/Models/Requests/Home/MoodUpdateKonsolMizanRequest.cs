using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateKonsolMizanRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateKonsolMizanQuery
    {
        public MoodUpdateKonsolMizanRequest Request { get; set; }
    }
}
