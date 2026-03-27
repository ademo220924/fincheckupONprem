using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class MoodUpdateReportRequest
    {
        public XMlookUpdate PageIndex { get; set; }
    }

    public class MoodUpdateReportQuery
    {
        public MoodUpdateReportRequest Request { get; set; }
    }
}
