
namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class PayWithQNBpayRequest
{
    public PaymentModelRequest PaymentModelRequest { get; set; }
}

public class PayWithQNBpayQuery
{
    public PayWithQNBpayRequest Request { get; set; }
}
