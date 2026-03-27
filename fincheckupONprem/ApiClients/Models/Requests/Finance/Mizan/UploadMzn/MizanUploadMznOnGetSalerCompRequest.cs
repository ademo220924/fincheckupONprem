using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMznOnGetSalerCompQuery
    {
        public MizanUploadMznOnGetSalerCompRequest Request { get; set; }
    }
}
