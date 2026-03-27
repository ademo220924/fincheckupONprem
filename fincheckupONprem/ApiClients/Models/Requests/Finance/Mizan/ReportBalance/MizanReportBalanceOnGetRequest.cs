
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportBalance
{
    public class MizanReportBalanceOnGetRequest
    {
        public int nyear { get; set; } = 2021;
    }

    public class MizanReportBalanceOnGetQuery
    {
        public MizanReportBalanceOnGetRequest Request { get; set; }
    }
}
