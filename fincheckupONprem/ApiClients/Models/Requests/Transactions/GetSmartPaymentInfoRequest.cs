namespace fincheckup.ApiClients.Models.Requests.Transactions;

public class GetSmartPaymentInfoRequest : PaymentModelRequest;

public class GetSmartPaymentInfoQuery
{
    public GetSmartPaymentInfoRequest Request { get; set; }
}
