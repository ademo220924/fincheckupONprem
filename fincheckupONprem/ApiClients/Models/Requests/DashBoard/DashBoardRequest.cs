using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models;


namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardRequest
{

    public IEnumerable<YearResult> myearResult;
    public long UserID;
    public string CompName;
    public long CompID;
    public int CompCount;
    public int YearCount;
    public HhvnUsers CurrentUser;
    public YearlyErrorResultView mrequestEntryView;
    public IEnumerable<Entities.Bulten> bultenList;
    public IEnumerable<Entities.Company> mreqListCompany;
    public DataViewerMain mrequestDataViewer;
    public TaxErrorCheck ttdashChk;
    public TaxErrorcheckTest ttdashTest;
    public TaxErrorcheckDataz ttdashDataz;
}