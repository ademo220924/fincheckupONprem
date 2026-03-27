using fincheckup.ApiClients.Models.Requests.FinansmanWsdl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for FinansmanWsdlController. Source: src/FinanceCheckUp.Api/Controllers/v1/FinansmanWsdlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinansmanWsdlClient : IApiClientBase
{
    [Post("/api/finansman-wsdl/deneme")]
    Task<object> DenemeAsync([Body] FinansmanEntegrasyonRequest finansmanEntegrasyonRequest, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/qnb/userid")]
    Task<FinansmanEntegrasyonResponse> ValidationByQnbUserIdRequestAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/uyumsoft/userid-password")]
    Task<FinansmanEntegrasyonResponse> ValidationUyumSoftByUserIdPasswordAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/userid-password")]
    Task<FinansmanEntegrasyonResponse> ValidationByUserIdPasswordAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/defter-izin-sil")]
    Task<FinansmanEntegrasyonResponse> ValidationDefterIzinSilAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/defter-izin-sil-bank")]
    Task<FinansmanEntegrasyonResponse> ValidationDefterIzinSilBankAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finansman-wsdl/defter-izin-kaydet")]
    Task<FinansmanEntegrasyonResponse> ValidationDefterIzinKaydetAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken = default);
}
