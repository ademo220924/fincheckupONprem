
namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalanceAkt
{
    public class FinanceUpBalanceAktOnGetRequest
    {
        public int nyear = 2021;
    }

    public class FinanceUpBalanceAktOnGetQuery
    {
        public FinanceUpBalanceAktOnGetRequest Request { get; set; }
    }
}
