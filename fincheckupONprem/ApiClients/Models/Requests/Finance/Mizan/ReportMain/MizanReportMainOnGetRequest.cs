
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetRequest
    {
        public MizanReportMainRequestInitialModel RequestInitialModel { get; set; }
    }

    public class MizanReportMainOnGetQuery
    {
        public MizanReportMainOnGetRequest Request { get; set; }
    }
}
