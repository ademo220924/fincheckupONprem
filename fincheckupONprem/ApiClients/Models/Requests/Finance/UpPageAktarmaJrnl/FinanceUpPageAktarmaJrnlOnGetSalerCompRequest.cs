using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaJrnlOnGetSalerCompQuery
    {
        public FinanceUpPageAktarmaJrnlOnGetSalerCompRequest Request { get; set; }
    }
}
