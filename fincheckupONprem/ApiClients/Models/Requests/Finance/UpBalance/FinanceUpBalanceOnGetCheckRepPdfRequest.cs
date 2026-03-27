
namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalance
{
    public class FinanceUpBalanceOnGetCheckRepPdfRequest
    {
        public long companyID {  get; set; }
        public int nyear { get; set; }
    }

    public class FinanceUpBalanceOnGetCheckRepPdfQuery
    {
        public FinanceUpBalanceOnGetCheckRepPdfRequest Request { get; set; }
    }
}
