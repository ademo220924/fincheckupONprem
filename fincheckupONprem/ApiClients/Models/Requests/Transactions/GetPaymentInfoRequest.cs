
namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class GetPaymentInfoRequest : PaymentModelRequest;

public class GetPaymentInfoQuery
{
    public GetPaymentInfoRequest Request { get; set; }
}
