using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpReportMain
{
    public class FinanceUpReportMainOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceUpReportMainOnGetSalerYearQuery
    {
        public FinanceUpReportMainOnGetSalerYearRequest Request { get; set; }
    }
}
