using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpReportMain
{
    public class FinanceUpReportMainOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpReportMainOnGetSalerDateQuery
    {
        public FinanceUpReportMainOnGetSalerDateRequest Request { get; set; }
    }
}
