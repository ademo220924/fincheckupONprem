using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol
{
    public class MizanCompanyKonsolRequestInitialModel
    {
        public Entities.Company mrequest;
        public Entities.Company mrequestmain;
        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}
