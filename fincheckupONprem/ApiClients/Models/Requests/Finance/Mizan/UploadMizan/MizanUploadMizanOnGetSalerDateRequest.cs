using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMizanOnGetSalerDateQuery
    {
        public MizanUploadMizanOnGetSalerDateRequest Request { get; set; }
    }
}
