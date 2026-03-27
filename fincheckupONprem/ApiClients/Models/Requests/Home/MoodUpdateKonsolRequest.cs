using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateKonsolRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateKonsolQuery
    {
        public MoodUpdateKonsolRequest Request { get; set; }
    }
}
