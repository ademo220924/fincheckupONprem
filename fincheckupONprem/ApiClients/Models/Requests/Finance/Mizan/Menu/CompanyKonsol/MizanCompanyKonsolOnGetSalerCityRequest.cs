using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol
{
    public class MizanCompanyKonsolOnGetSalerCityRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanCompanyKonsolOnGetSalerCityQuery
    {
        public MizanCompanyKonsolOnGetSalerCityRequest Request { get; set; }
    }
}
