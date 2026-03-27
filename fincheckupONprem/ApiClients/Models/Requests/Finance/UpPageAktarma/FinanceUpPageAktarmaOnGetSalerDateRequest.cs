using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma
{
    public class FinanceUpPageAktarmaOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaOnGetSalerDateQuery
    {
        public FinanceUpPageAktarmaOnGetSalerDateRequest Request { get; set; }
    }
}
