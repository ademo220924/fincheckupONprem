using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.UserEdit
{
    public class UserEditOnGetSalerMainRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class UserEditOnGetSalerMainQuery
    {
        public UserEditOnGetSalerMainRequest Request { get; set; }
    }
}
