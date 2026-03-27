using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Mizan
{
    public class MoodUpdatesAktarmaMznRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdatesAktarmaMznQuery
    {
        public MoodUpdatesAktarmaMznRequest Request { get; set; }
    }
}
