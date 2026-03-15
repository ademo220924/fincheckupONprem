namespace fincheckup.ApiClients.Models.Common;

public class ClientResponseModel
{
    public int StatusCode { get; set; } = 500;
    public bool IsSuccess { get; set; } = false;
    public string Message { get; set; } = string.Empty;
}