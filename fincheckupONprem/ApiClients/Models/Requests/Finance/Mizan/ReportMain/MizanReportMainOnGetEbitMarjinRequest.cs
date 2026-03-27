using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetEbitMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanReportMainOnGetEbitMarjinQuery
    {
        public MizanReportMainOnGetEbitMarjinRequest Request { get; set; }
    }
}
