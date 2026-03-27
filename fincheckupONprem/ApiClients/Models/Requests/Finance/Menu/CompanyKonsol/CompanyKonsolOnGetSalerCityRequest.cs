using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsol
{
    public class CompanyKonsolOnGetSalerCityRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class CompanyKonsolOnGetSalerCityQuery
    {
        public CompanyKonsolOnGetSalerCityRequest Request { get; set; }
    }
}
