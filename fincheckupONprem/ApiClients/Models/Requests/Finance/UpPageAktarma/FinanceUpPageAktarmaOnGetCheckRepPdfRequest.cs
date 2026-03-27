
namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma
{
    public class FinanceUpPageAktarmaOnGetCheckRepPdfRequest
    {
        public long companyID {  get; set; }
        public int nyear { get; set; }
    }

    public class FinanceUpPageAktarmaOnGetCheckRepPdfQuery
    {
        public FinanceUpPageAktarmaOnGetCheckRepPdfRequest Request { get; set; }
    }
}
