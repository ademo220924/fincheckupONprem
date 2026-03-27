using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit
{
    public class CompanyEditInitialModel
    {
        public long UserID { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public Entities.Company mrequest { get; set; }

        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}