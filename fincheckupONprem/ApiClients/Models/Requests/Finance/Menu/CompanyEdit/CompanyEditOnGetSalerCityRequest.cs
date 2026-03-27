using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit
{
    public class CompanyEditOnGetSalerCityRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class CompanyEditOnGetSalerCityQuery
    {
        public CompanyEditOnGetSalerCityRequest Request { get; set; }
    }
}
