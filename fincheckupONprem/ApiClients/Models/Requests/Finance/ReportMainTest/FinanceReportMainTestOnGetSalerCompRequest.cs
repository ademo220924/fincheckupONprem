using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceReportMainTestOnGetSalerCompQuery
    {
        public FinanceReportMainTestOnGetSalerCompRequest Request { get; set; }
    }
}
