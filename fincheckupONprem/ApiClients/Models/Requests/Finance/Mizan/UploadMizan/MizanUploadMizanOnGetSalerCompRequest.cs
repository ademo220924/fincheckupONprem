using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMizanOnGetSalerCompQuery
    {
        public MizanUploadMizanOnGetSalerCompRequest Request { get; set; }
    }
}
