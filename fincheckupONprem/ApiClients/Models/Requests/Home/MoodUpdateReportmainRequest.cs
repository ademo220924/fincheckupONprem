using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateReportmainRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateReportmainQuery
    {
        public MoodUpdateReportmainRequest Request { get; set; }
    }
}
