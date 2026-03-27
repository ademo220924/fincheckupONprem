using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaJrnlOnGetSalerDateQuery
    {
        public FinanceUpPageAktarmaJrnlOnGetSalerDateRequest Request { get; set; }
    }
}
