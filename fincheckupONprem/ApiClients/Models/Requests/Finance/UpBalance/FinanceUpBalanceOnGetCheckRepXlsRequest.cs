
namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetCheckRepXlsRequest
    {
        public long companyID {  get; set; }
        public int nyear { get; set; }
    }

    public class FinanceUpBalanceOnGetCheckRepXlsQuery
    {
        public FinanceUpBalanceOnGetCheckRepXlsRequest Request { get; set; }
    }
}
