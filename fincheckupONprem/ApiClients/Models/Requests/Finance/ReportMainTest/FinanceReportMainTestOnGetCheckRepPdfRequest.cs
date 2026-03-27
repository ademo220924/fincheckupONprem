
namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest
{
    public class FinanceReportMainTestOnGetCheckRepPdfRequest
    {
        public long companyID {  get; set; }
        public string nacceco { get; set; }
    }

    public class FinanceReportMainTestOnGetCheckRepPdfQuery
    {
        public FinanceReportMainTestOnGetCheckRepPdfRequest Request { get; set; }
    }
}
