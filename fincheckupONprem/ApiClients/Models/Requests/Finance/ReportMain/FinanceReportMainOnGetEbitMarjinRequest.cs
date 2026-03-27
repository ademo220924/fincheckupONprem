using DevExtreme.AspNet.Mvc;

 namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMain
{
    public class FinanceReportMainOnGetEbitMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class FinanceReportMainOnGetEbitMarjinQuery
    {
        public FinanceReportMainOnGetEbitMarjinRequest Request { get; set; }
    }
}
