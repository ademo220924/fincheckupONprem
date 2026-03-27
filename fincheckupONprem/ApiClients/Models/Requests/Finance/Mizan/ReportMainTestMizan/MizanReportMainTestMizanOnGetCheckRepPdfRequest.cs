
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetCheckRepPdfRequest
    {
        public long companyID { get; set; }
        public string nacceco { get; set; }
    }

    public class MizanReportMainTestMizanOnGetCheckRepPdfQuery
    {
        public MizanReportMainTestMizanOnGetCheckRepPdfRequest Request { get; set; }
    }
}
