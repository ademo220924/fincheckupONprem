using DevExtreme.AspNet.Mvc;


namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordOnGetSalerMainRequest
{
    public ChangePasswordRequest InitialModel { get; set; }
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}