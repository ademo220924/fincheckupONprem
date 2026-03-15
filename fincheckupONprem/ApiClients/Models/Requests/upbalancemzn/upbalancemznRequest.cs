using fincheckup.ApiClients.Entities;
using System.Collections.Generic;
using fincheckup.ApiClients.Models.ViewModel.Reports;


namespace fincheckup.ApiClients.Models.Requests.upbalancemzn;
public class upbalancemznRequest
{
    public long UserID;
    public long CompID;
    public string header;
    public Entities.Company CCompany;
    public HhvnUsers CurrentUser;
    public IEnumerable<Entities.Company> mreqListCompany;
    public List<ReportSet> ncheck;
}