using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit
{
    public class CompanyEditInitialModel
    {
        public long UserID;
        public HhvnUsers CurrentUser;
        public Entities.Company mrequest;

        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}