using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Mizan;

public class MoodUpdatesAktarmaSelectedMznRequest
{
    public XMlookUpdate XMlookUpdate { get; set; }
}

public class MoodUpdatesAktarmaSelectedMznQuery
{
    public MoodUpdatesAktarmaSelectedMznRequest Request { get; set; }
}
