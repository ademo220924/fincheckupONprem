using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit
{
    public class UserEditOnGetSalerCityRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class UserEditOnGetSalerCityQuery
    {
        public UserEditOnGetSalerCityRequest Request { get; set; }
    }
}
