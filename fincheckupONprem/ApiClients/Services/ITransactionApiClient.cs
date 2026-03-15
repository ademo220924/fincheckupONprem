using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.Transactions;
using fincheckup.ApiClients.Models.Responses.Transactions;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface ITransactionApiClient: IApiClientBase
{
    // POST: /api/transaction/PaySmartNomb
    [Post("/api/transaction/PaySmartNomb")]
    Task<GenericResult<SmartPaymentResponse>> PaySmartNombAsync([Body] PaySmartNombRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/PaySmart
    [Post("/api/transaction/PaySmart")]
    Task<GenericResult<PaySmartResponse>> PaySmartAsync([Body] PaySmartRequest request, CancellationToken cancellationToken);

    // Post: /api/transaction/GetSmartPaymentInfoNomb
    [Post("/api/transaction/GetSmartPaymentInfoNomb")]
    Task<GenericResult<GetSmartPaymentInfoNombResponse>> GetSmartPaymentInfoNombAsync([Body] GetSmartPaymentInfoNombRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/PayWithQNBpay
    [Post("/api/transaction/PayWithQNBpay")]
    Task<GenericResult<PayWithQNBpayResponse>> PayWithQNBpayAsync([Body] PayWithQNBpayRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/Refund
    [Post("/api/transaction/Refund")]
    Task<GenericResult<RefundResponse>> RefundAsync([Body] RefundRequest request, CancellationToken cancellationToken);

    // Post: /api/transaction/CheckBinCode
    [Post("/api/transaction/CheckBinCode")]
    Task<GenericResult<CheckBinCodeResponse>> CheckBinCodeAsync([Body] CheckBinCodeRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/SuccessUrl
    [Post("/api/transaction/SuccessUrl")]
    Task<GenericResult<SuccessUrlResponse>> SuccessUrlAsync([Body] SuccessUrlRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/CancelUrl
    [Post("/api/transaction/CancelUrl")]
    Task<GenericResult<CancelUrlResponse>> CancelUrlAsync([Body] CancelUrlRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/BrandedSuccessUrl
    [Post("/api/transaction/BrandedSuccessUrl")]
    Task<GenericResult<BrandedSuccessUrlResponse>> BrandedSuccessUrlAsync([Body] BrandedSuccessUrlRequest request, CancellationToken cancellationToken);

    // POST: /api/transaction/BrandedCancelUrl
    [Post("/api/transaction/BrandedCancelUrl")]
    Task<GenericResult<BrandedCancelUrlResponse>> BrandedCancelUrlAsync([Body] BrandedCancelUrlRequest request, CancellationToken cancellationToken);

    // GET: /api/transaction/Error
    [Post("/api/transaction/Error")]
    Task<GenericResult<ErrorViewModel>> ErrorAsync([Body] ErrorRequest request, CancellationToken cancellationToken);

    // GET: /api/transaction/GetPaymentInfo
    [Post("/api/transaction/GetPaymentInfo")]
    Task<GenericResult<PaymentModel>> GetPaymentInfoAsync([Body] GetPaymentInfoRequest request, CancellationToken cancellationToken);

    // GET: /api/transaction/GetSmartPaymentInfo
    [Post("/api/transaction/GetSmartPaymentInfo")]
    Task<GenericResult<PaymentModel>> GetSmartPaymentInfoAsync([Body] GetSmartPaymentInfoRequest request, CancellationToken cancellationToken);
}