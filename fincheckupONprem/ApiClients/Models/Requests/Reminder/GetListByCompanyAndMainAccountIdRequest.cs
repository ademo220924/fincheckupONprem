namespace fincheckup.ApiClients.Models.Requests.Reminder;

public class GetListByCompanyAndMainAccountIdRequest
{
    public long CompanyId { get; set; }
    public long AccountId { get; set; }
}
