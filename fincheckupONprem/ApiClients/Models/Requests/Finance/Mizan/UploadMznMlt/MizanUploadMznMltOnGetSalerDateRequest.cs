using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt
{
    public class MizanUploadMznMltOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMznMltOnGetSalerDateQuery
    {
        public MizanUploadMznMltOnGetSalerDateRequest Request { get; set; }
    }
}
