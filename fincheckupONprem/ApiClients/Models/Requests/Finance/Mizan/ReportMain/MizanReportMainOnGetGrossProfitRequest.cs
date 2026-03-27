using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetGrossProfitRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanReportMainOnGetGrossProfitQuery
    {
        public MizanReportMainOnGetGrossProfitRequest Request { get; set; }
    }
}
