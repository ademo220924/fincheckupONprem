
namespace fincheckup.ApiClients.Models.Requests.Finance.UpReportMain
{
    public class FinanceUpReportMainOnGetCheckRepXlsRequest
    {
        public long companyID { get; set; }
        public int nyear { get; set; }
    }

    public class FinanceUpReportMainOnGetCheckRepXlsQuery
    {
        public FinanceUpReportMainOnGetCheckRepXlsRequest Request { get; set; }
    }
}
