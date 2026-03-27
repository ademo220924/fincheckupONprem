using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerMainZetaRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public int monthid { get; set; }
    }

    public class MizanUploadMizanOnGetSalerMainZetaQuery
    {
        public MizanUploadMizanOnGetSalerMainZetaRequest Request { get; set; }
    }
}
