using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserEdit
{
    public class MizanUserEditOnGetSalerMainRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUserEditOnGetSalerMainQuery
    {
        public MizanUserEditOnGetSalerMainRequest Request { get; set; }
    }
}
