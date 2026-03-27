using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsolList
{
    public class CompanyKonsolListInitialModel
    {
        public int UserID { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Entities.Company> mreqList { get; set; }
        public Entities.Company mrequest { get; set; }
    }
}
