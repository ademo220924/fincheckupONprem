using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.ViewModel;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn
{
    public class MizanUploadMznRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public long curcomID;
        public int curcomCount;
        public DataViewerMain mrequestDataViewer;
        public HhvnUsers CurrentUser;
        public List<YearlyErrorResult> currentUploadM;
        public List<int> currentUploadYear;


        public IEnumerable<Entities.Company> mreqListCompany;
        public Entities.Company currenCompanie;
        public string CompName;


        public string currentcompname { get; set; }
    }
}
