using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt
{
    public class MizanUploadMznMltOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMznMltOnGetSalerCompQuery
    {
        public MizanUploadMznMltOnGetSalerCompRequest Request { get; set; }
    }
}
