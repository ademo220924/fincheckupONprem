using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUpPageAktarmaOnGetSalerYearQuery
    {
        public MizanUpPageAktarmaOnGetSalerYearRequest Request { get; set; }
    }
}
