using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMznOnGetSalerDateQuery
    {
        public MizanUploadMznOnGetSalerDateRequest Request { get; set; }
    }
}
