using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn
{
    public class FinanceUpPageAktarmaMznOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpPageAktarmaMznOnGetSalerCompQuery
    {
        public FinanceUpPageAktarmaMznOnGetSalerCompRequest Request { get; set; }
    }
}
