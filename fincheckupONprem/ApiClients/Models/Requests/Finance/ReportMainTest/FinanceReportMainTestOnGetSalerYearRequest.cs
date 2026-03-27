using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceReportMainTestOnGetSalerYearQuery
    {
        public FinanceReportMainTestOnGetSalerYearRequest Request { get; set; }
    }
}
