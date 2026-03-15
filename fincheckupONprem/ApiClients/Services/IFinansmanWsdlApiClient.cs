using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.FinansmanWsdl;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IFinansmanWsdlApiClient : IApiClientBase
{
    [Post("/api/finansman-wsdl/deneme")]
    Task<GenericResult<HttpResponseMessage>> DenemeAsync([Body] FinansmanEntegrasyonRequest request);

    [Post("/api/finansman-wsdl/qnb/userid")]
    Task<GenericResult<HttpResponseMessage>> ValidationByQnbUserIdRequestAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);

    [Post("/api/finansman-wsdl/uyumsoft/userid-password")]
    Task<GenericResult<HttpResponseMessage>> ValidationUyumSoftByUserIdPasswordAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);

    [Post("/api/finansman-wsdl/userid-password")]
    Task<GenericResult<HttpResponseMessage>> ValidationByUserIdPasswordAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);

    [Post("/api/finansman-wsdl/defter-izin-sil")]
    Task<GenericResult<HttpResponseMessage>> ValidationDefterIzinSilAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);

    [Post("/api/finansman-wsdl/defter-izin-sil-bank")]
    Task<GenericResult<HttpResponseMessage>> ValidationDefterIzinSilBankAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);

    [Post("/api/finansman-wsdl/defter-izin-kaydet")]
    Task<GenericResult<HttpResponseMessage>> ValidationDefterIzinKaydetAsync([Body] FinansmanEntegrasyonRequest request, CancellationToken cancellationToken);
}