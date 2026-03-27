using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadSmmOnGetSalerCompQuery
    {
        public MizanUploadSmmOnGetSalerCompRequest Request { get; set; }
    }
}
