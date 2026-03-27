using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainOnGetDonemselKarZararRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanReportMainOnGetDonemselKarZararQuery
    {
        public MizanReportMainOnGetDonemselKarZararRequest Request { get; set; }
    }
}
