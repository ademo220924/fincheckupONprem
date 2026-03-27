using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznOnGetSalerMainChkRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public int monthid { get; set; }
    }

    public class MizanUploadMznOnGetSalerMainChkQuery
    {
        public MizanUploadMznOnGetSalerMainChkRequest Request { get; set; }
    }
}
