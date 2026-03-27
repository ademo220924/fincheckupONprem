
namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class RefundRequest
{
    public PaymentModelRequest PaymentModelRequest { get; set; }
}

public class RefundQuery
{
    public RefundRequest Request { get; set; }
}
