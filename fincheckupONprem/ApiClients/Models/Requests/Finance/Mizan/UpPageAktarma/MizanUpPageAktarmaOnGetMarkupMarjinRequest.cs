using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }

        public long compid { get; set; }
    }

    public class MizanUpPageAktarmaOnGetMarkupMarjinQuery
    {
        public MizanUpPageAktarmaOnGetMarkupMarjinRequest Request { get; set; }

        public MizanUpPageAktarmaRequestInitialModel InitialModel { get; set; }
    }
}
