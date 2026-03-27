using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma
{
    public class FinanceUpPageAktarmaOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaOnGetSalerYearQuery
    {
        public FinanceUpPageAktarmaOnGetSalerYearRequest Request { get; set; }
    }
}
