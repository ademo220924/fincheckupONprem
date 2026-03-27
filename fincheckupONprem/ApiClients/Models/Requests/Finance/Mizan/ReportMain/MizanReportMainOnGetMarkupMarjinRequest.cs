using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanReportMainOnGetMarkupMarjinQuery
    {
        public MizanReportMainOnGetMarkupMarjinRequest Request { get; set; }
    }
}
