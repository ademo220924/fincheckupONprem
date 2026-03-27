using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan
{
    public class MizanUploadMzanOnGetSalerMainZetaRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int monthid { get; set; }
    }

    public class MizanUploadMzanOnGetSalerMainZetaQuery
    {
        public MizanUploadMzanOnGetSalerMainZetaRequest Request { get; set; }
    }
}
