namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class CheckBinCodeRequest
{
    public string BinCode { get; set; }
    public decimal Amount { get; set; }
    public bool IsRecurring { get; set; }
}

public class CheckBinCodeQuery
{
    public CheckBinCodeRequest Request { get; set; }
}
