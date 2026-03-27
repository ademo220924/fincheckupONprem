
namespace fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld
{
    public class FinanceReportMainTestOldOnGetCheckRepPdfRequest
    {
        public long companyID { get; set; }
        public string nacceco { get; set; }
    }

    public class FinanceReportMainTestOldOnGetCheckRepPdfQuery
    {
        public FinanceReportMainTestOldOnGetCheckRepPdfRequest Request { get; set; }
    }
}
