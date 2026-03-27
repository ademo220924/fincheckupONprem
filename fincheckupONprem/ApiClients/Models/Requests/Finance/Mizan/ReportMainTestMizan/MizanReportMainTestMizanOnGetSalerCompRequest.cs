using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanReportMainTestMizanOnGetSalerCompQuery
    {
        public MizanReportMainTestMizanOnGetSalerCompRequest Request { get; set; }
    }
}
