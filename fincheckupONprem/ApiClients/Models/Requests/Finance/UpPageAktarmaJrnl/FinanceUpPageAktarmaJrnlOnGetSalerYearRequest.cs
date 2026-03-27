using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl
{
    public class FinanceUpPageAktarmaJrnlOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaJrnlOnGetSalerYearQuery
    {
        public FinanceUpPageAktarmaJrnlOnGetSalerYearRequest Request { get; set; }
    }
}
