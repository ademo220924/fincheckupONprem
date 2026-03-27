using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMain
{
    public class FinanceReportMainOnGetGraphZetRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class FinanceReportMainOnGetGraphZetQuery
    {
        public FinanceReportMainOnGetGraphZetRequest Request { get; set; }
    }
}
