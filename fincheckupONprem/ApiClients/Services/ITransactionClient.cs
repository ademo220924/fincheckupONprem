using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for TransactionController. Source: src/FinanceCheckUp.Api/Controllers/v1/TransactionController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface ITransactionClient : IApiClientBase
{
    [Post("/api/transaction/PaySmartNomb")]
    Task<GenericResult<SmartPaymentResponse>> PaySmartNombAsync([Body] PaySmartNombRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/PaySmart")]
    Task<GenericResult<PaySmartResponse>> PaySmartAsync([Body] PaySmartRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/GetSmartPaymentInfoNomb")]
    Task<GenericResult<GetSmartPaymentInfoNombResponse>> GetSmartPaymentInfoNombAsync([Body] GetSmartPaymentInfoNombRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/PayWithQNBpay")]
    Task<GenericResult<PayWithQNBpayResponse>> PayWithQNBpayAsync([Body] PayWithQNBpayRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/Refund")]
    Task<GenericResult<RefundResponse>> RefundAsync([Body] RefundRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/CheckBinCode")]
    Task<GenericResult<CheckBinCodeResponse>> CheckBinCodeAsync([Body] CheckBinCodeRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/SuccessUrl")]
    Task<GenericResult<SuccessUrlResponse>> SuccessUrlAsync([Body] SuccessUrlRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/CancelUrl")]
    Task<GenericResult<CancelUrlResponse>> CancelUrlAsync([Body] CancelUrlRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/BrandedSuccessUrl")]
    Task<GenericResult<BrandedSuccessUrlResponse>> BrandedSuccessUrlAsync([Body] BrandedSuccessUrlRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/BrandedCancelUrl")]
    Task<GenericResult<BrandedCancelUrlResponse>> BrandedCancelUrlAsync([Body] BrandedCancelUrlRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/Error")]
    Task<GenericResult<ErrorViewModel>> ErrorAsync([Body] ErrorRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/GetPaymentInfo")]
    Task<GenericResult<PaymentModel>> GetPaymentInfoAsync([Body] GetPaymentInfoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/transaction/GetSmartPaymentInfo")]
    Task<GenericResult<PaymentModel>> GetSmartPaymentInfoAsync([Body] GetSmartPaymentInfoRequest request, CancellationToken cancellationToken = default);
}
