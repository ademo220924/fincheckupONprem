using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList
{
    public class CompanyKonsolListOnGetKonListRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long ide {  get; set; }
    }

    public class CompanyKonsolListOnGetKonListQuery
    {
        public CompanyKonsolListOnGetKonListRequest Request { get; set; }
    }
}
