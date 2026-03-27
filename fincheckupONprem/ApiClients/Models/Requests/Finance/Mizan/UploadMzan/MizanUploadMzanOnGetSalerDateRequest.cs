using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan
{
    public class MizanUploadMzanOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMzanOnGetSalerDateQuery
    {
        public MizanUploadMzanOnGetSalerDateRequest Request { get; set; }
    }
}
