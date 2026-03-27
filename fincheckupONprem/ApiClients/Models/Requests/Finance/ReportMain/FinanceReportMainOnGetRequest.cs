
namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMain
{
    public class FinanceReportMainOnGetRequest
    {
        public FinanceReportMainRequestInitialModel RequestInitialModel { get; set; }
    }

    public class FinanceReportMainOnGetQuery
    {
        public FinanceReportMainOnGetRequest Request { get; set; }
    }
}
