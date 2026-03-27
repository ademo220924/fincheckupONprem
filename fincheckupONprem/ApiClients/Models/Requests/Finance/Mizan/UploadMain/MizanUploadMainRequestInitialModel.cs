using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain
{
    public class MizanUploadMainRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult { get; set; }
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public long curcomID { get; set; }
        public int curcomCount { get; set; }
        public DataViewerMain mrequestDataViewer { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public List<YearlyErrorResult> currentUploadM { get; set; }
        public List<int> currentUploadYear { get; set; }

        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public Entities.Company currenCompanie { get; set; }
        public string CompName { get; set; }

        public string currentcompname { get; set; }
    }
}
