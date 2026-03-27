using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Mizan
{
    public class MoodUpdatesAktarmaRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdatesAktarmaQuery
    {
        public MoodUpdatesAktarmaRequest Request { get; set; }
    }
}
