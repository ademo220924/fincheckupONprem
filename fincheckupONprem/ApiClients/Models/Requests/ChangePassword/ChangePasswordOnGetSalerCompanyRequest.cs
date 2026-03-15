using DevExtreme.AspNet.Mvc;


namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordOnGetSalerCompanyRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public ChangePasswordRequest InitialModel { get; set; }
}