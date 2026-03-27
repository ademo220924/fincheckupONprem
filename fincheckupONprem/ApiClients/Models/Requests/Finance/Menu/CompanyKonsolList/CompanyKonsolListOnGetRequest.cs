
namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList
{
    public class CompanyKonsolListOnGetRequest
    {
        public int id {get; set;}
    }

    public class CompanyKonsolListOnGetQuery
    {
        public CompanyKonsolListOnGetRequest Request { get; set; }
    }
}
