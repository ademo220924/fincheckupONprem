using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsol
{
    public class CompanyKonsolOnGetSalerEntegRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class CompanyKonsolOnGetSalerEntegQuery
    {
        public CompanyKonsolOnGetSalerEntegRequest Request { get; set; }
    }
}
