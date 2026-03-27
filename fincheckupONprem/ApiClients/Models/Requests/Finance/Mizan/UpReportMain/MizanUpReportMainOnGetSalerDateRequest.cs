using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain
{
    public class MizanUpReportMainOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUpReportMainOnGetSalerDateQuery
    {
        public MizanUpReportMainOnGetSalerDateRequest Request { get; set; }
    }
}
