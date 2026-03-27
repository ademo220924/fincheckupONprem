using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMainOnGetSalerCompQuery
    {
        public MizanUploadMainOnGetSalerCompRequest Request { get; set; }
    }
}
