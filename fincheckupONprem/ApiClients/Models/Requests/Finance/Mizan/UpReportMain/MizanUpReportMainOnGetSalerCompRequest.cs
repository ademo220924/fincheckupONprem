using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain
{
    public class MizanUpReportMainOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUpReportMainOnGetSalerCompQuery
    {
        public MizanUpReportMainOnGetSalerCompRequest Request { get; set; }
    }
}
