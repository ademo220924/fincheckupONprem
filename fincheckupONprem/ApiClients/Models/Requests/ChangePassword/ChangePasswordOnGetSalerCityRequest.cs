using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.ChangePassword;
public class ChangePasswordOnGetSalerCityRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class ChangePasswordOnGetSalerCityQuery
{
    public ChangePasswordOnGetSalerCityRequest Request { get; set; }
}
