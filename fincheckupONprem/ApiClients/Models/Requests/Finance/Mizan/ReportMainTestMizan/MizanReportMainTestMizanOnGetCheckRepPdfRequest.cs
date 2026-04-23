
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetCheckRepPdfRequest
    {
        public long companyID { get; set; }
        public string nacceco { get; set; }
    }

    public class MizanReportMainTestMizanOnGetCheckRepPdfQuery
    {
        [JsonIgnore] public  string UserId { get; set; }
        public MizanReportMainTestMizanOnGetCheckRepPdfRequest Request { get; set; }
        public MizanReportMainTestMizanRequestInitialModel InitialModel { get; set; }
    }
}
