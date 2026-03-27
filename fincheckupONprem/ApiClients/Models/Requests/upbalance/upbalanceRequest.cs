using fincheckup.ApiClients.Entities;

using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceRequest
{

    public IEnumerable<YearResult> myearResult;
    public long UserID;
    public long CompID;
    public int CompCount;
    public int YearCount;
    public long curcomID;
    public int curcomCount;

    public int YearCurrent;
    public HhvnUsers CurrentUser;

    public IEnumerable<Entities.Company> mreqListCompany;
    public Entities.Company curCompany;

    public string CompName;

    public string currentcompname { get; set; }
}

public class upbalanceQuery
{
    public upbalanceRequest Request { get; set; }
}
