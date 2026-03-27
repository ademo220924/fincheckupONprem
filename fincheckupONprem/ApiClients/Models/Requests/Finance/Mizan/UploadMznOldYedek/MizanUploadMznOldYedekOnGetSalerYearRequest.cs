using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznOldYedek
{
    public class MizanUploadMznOldYedekOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMznOldYedekOnGetSalerYearQuery
    {
        public MizanUploadMznOldYedekOnGetSalerYearRequest Request { get; set; }
    }
}
