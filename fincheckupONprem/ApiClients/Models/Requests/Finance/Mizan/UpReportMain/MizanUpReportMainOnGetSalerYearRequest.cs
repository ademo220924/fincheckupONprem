using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain
{
    public class MizanUpReportMainOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUpReportMainOnGetSalerYearQuery
    {
        public MizanUpReportMainOnGetSalerYearRequest Request { get; set; }
    }
}
