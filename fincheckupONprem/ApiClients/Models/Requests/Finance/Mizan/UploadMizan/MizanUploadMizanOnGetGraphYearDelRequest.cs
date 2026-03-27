
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetGraphYearDelRequest
    {
        public int nyear {  get; set; }
        public int compide {  get; set; }
    }

    public class MizanUploadMizanOnGetGraphYearDelQuery
    {
        public MizanUploadMizanOnGetGraphYearDelRequest Request { get; set; }
    }
}
