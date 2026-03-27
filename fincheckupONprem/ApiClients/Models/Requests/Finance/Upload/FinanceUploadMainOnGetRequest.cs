
namespace fincheckup.ApiClients.Models.Requests.Finance.Upload
{
    public class FinanceUploadMainOnGetRequest
    {
        public FinanceUploadMainRequestInitialModel RequestInitialModel { get; set; }
    }

    public class FinanceUploadMainOnGetQuery
    {
        public FinanceUploadMainOnGetRequest Request { get; set; }
    }
}
