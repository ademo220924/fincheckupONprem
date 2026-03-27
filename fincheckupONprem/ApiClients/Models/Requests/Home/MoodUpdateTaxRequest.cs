using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateTaxRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateTaxQuery
    {
        public MoodUpdateTaxRequest Request { get; set; }
    }
}
