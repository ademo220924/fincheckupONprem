using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyList
{
    public class MizanCompanyListRequestInitialModel
    {
        public long UserID { get; set; } 
        public int UserTypeID { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Entities.Company> mreqList { get; set; }
    }
}
