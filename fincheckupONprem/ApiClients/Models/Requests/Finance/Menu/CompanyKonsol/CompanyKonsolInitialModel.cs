using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsol
{
    public class CompanyKonsolInitialModel
    {
        public Entities.Company mrequest { get; set; }
        public Entities.Company mrequestmain { get; set; }
        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}
