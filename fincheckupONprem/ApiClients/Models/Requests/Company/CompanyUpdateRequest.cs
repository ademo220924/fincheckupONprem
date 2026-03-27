namespace fincheckup.ApiClients.Models.Requests.Company;

public class CompanyUpdateRequest : CompanyRequest
{
    public long Id { get; set; }
}

public class CompanyUpdateQuery
{
    public CompanyUpdateRequest Request { get; set; }
}
