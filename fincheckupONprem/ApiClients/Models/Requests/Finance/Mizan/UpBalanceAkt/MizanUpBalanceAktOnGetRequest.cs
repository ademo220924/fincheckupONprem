
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt
{
    public class MizanUpBalanceAktOnGetRequest
    {
        public int nyear { get; set; } = 2021;
    }

    public class MizanUpBalanceAktOnGetQuery
    {
        public MizanUpBalanceAktOnGetRequest Request { get; set; }
    }
}
