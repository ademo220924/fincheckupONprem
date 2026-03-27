using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznOldYedek
{
    public class MizanUploadMznOldYedekOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMznOldYedekOnGetSalerDateQuery
    {
        public MizanUploadMznOldYedekOnGetSalerDateRequest Request { get; set; }
    }
}
