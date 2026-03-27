
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma
{
    public class MizanUpPageAktarmaOnGetCheckRepPdfRequest
    {
        public long companyID {  get; set; }
        public int nyear { get; set; }
    }

    public class MizanUpPageAktarmaOnGetCheckRepPdfQuery
    {
        public MizanUpPageAktarmaOnGetCheckRepPdfRequest Request { get; set; }
    }
}
