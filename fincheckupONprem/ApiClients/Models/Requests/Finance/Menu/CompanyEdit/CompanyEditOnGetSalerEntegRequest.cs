using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit
{
    public class CompanyEditOnGetSalerEntegRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class CompanyEditOnGetSalerEntegQuery
    {
        public CompanyEditOnGetSalerEntegRequest Request { get; set; }
    }
}
