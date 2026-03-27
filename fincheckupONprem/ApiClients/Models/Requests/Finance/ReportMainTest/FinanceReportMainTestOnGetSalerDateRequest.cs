using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceReportMainTestOnGetSalerDateQuery
    {
        public FinanceReportMainTestOnGetSalerDateRequest Request { get; set; }
    }
}
