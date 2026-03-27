using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordOnGetSalerMainRequest
{
    public ChangePasswordRequest InitialModel { get; set; }
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class ChangePasswordOnGetSalerMainQuery
{
    public ChangePasswordOnGetSalerMainRequest Request { get; set; }
}
