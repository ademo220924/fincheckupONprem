using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadSmmOnGetSalerDateQuery
    {
        public MizanUploadSmmOnGetSalerDateRequest Request { get; set; }
    }
}
