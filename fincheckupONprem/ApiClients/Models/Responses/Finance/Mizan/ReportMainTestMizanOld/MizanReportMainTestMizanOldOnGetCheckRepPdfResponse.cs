using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizanOld
{
    public class MizanReportMainTestMizanOldOnGetCheckRepPdfResponse
    {
        public JsonElement? Response { get; set; }
        public List<int> CurCompanyYearList { get; set; }
        public string? FilePath { get; set; }
        public long CompanyId { get; set; }
        public string Nacceco { get; set; }
        public long UserId { get; set; }
        public string Ncccode  { get; set; }
    }
}
