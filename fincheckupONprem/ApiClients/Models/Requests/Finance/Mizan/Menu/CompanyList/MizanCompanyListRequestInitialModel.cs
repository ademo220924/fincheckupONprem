using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyList
{
    public class MizanCompanyListRequestInitialModel
    {
        public long UserID; 
        public int UserTypeID;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqList;
    }
}
