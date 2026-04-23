using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizan
{
    public class MizanReportMainTestMizanOnGetCheckUrlResponse
    {
        [JsonPropertyName("fileUrl")]
        public string? FileUrl { get; set; }
    }
}
