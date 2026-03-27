
namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class PaySmartRequest
{
    public PaymentModelRequest PaymentModelRequest { get; set; }
}

public class PaySmartQuery
{
    public PaySmartRequest Request { get; set; }
}
