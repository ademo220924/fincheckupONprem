using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.Aggregated;

using System.Collections.Generic;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Requests.upaccounty;
public class upaccountyRequest
{

    public IEnumerable<YearResult> myearResult;
    public long UserID;
    public long CompID;
    public int CompCount;
    public int YearCount;
    public string TotalRowCount;
    public string TotalErrorCount;
    public long curcomID;
    public int curcomCount;

    public HhvnUsers CurrentUser;

    public IEnumerable<YearlyErrorResult> currentUploadError;

    public IEnumerable<Entities.Company> mreqListCompany;
    public DataViewerMain mrequestDataViewer;

    public string CompName;
    public string currentcompname { get; set; }
}

public class upaccountyQuery
{
    public upaccountyRequest Request { get; set; }
}
