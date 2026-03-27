using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUpPageAktarmaOnGetSalerCompQuery
    {
        public MizanUpPageAktarmaOnGetSalerCompRequest Request { get; set; }
    }
}
