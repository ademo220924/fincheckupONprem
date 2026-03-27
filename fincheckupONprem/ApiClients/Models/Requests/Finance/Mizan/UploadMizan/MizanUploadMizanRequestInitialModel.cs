using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.ViewModel.Mizan;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult { get; set; }
        public int UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public long curcomID { get; set; }
        public int curcomCount { get; set; }

        public HhvnUsers CurrentUser { get; set; }
        public YearlyUploadResult currentMonth { get; set; }
        public IEnumerable<TBLXMLSCheckpdfMizan> ncomparelist { get; set; }
        public IEnumerable<YearlyUploadResult> currentUploadM { get; set; }
        public IEnumerable<YearlyUploadResult> currentUploadMOK { get; set; }
        public IEnumerable<YearlyUploadResult> currentUploadMNoOK { get; set; }
        public List<YearlyUploadResult> currentUploadMMonth { get; set; }
        public List<byte> monthlist { get; set; }
        public DataViewerMain mrequestDataViewer { get; set; }
        public string mnthcomparelist { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public Entities.Company currenCompanie { get; set; }
        public string CompName { get; set; }


        public string currentcompname { get; set; }
    }
}
