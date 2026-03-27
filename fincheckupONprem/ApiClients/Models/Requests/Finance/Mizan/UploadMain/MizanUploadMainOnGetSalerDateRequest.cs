using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMainOnGetSalerDateQuery
    {
        public MizanUploadMainOnGetSalerDateRequest Request { get; set; }
    }
}
