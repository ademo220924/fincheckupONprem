using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld
{
    public class FinanceReportMainTestOldOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceReportMainTestOldOnGetSalerCompQuery
    {
        public FinanceReportMainTestOldOnGetSalerCompRequest Request { get; set; }
    }
}
