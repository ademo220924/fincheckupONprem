
namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class PaySmartNombRequest
{
    public PaymentModelRequest PaymentModelRequest { get; set; }
}

public class PaySmartNombQuery
{
    public PaySmartNombRequest Request { get; set; }
}
