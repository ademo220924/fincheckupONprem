using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.FinansmanWsdl;
using fincheckup.ApiClients.Services;

namespace fincheckup.Controllers;


[Route("JsonService/FinWsdl/[action]")]
public class FinWsdlController(IFinansmanWsdlApiClient finansmanWsdlApiClient) : Controller
{
    public async Task<JsonResult> ValidationByQnbUserIdRequest(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {

       var data= await finansmanWsdlApiClient.ValidationByQnbUserIdRequestAsync(new FinansmanEntegrasyonRequest(){FinansmanEntegrasyon = new FinansmanEntegrasyon()
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        }

    }
    public async Task<JsonResult> ValidationByUserIdPasswordUyumsoft(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {
        var data= await finansmanWsdlApiClient.ValidationUyumSoftByUserIdPasswordAsync(new FinansmanEntegrasyonRequest(){FinansmanEntegrasyon = new FinansmanEntegrasyon()
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        } 
    }
    public async Task<JsonResult> ValidationByUserIdPasswordRequest(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {

        var data= await finansmanWsdlApiClient.ValidationByUserIdPasswordAsync(new FinansmanEntegrasyonRequest(){FinansmanEntegrasyon = new FinansmanEntegrasyon()
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        } 

    }

    public async Task<JsonResult> ValidationdefterIzinSilRequest(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {

        var data= await finansmanWsdlApiClient.ValidationDefterIzinSilAsync(new FinansmanEntegrasyonRequest{FinansmanEntegrasyon = new FinansmanEntegrasyon
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        } 

    }
    public async Task<JsonResult> ValidationdefterIzinSilBank(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {
        var data= await finansmanWsdlApiClient.ValidationDefterIzinSilBankAsync(new FinansmanEntegrasyonRequest{FinansmanEntegrasyon = new FinansmanEntegrasyon
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        } 
    }
    public async Task<JsonResult> ValidationdefterIzinKaydetRequest(FinansmanEntegrasyonCs sendPar,CancellationToken cancellationToken)
    {

        var data= await finansmanWsdlApiClient.ValidationDefterIzinKaydetAsync(new FinansmanEntegrasyonRequest{FinansmanEntegrasyon = new FinansmanEntegrasyon
        {
            vknTckn = sendPar.vknTckn,
            ide = sendPar.ide,
            comide = sendPar.comide,
            hedefkaynak = sendPar.hedefkaynak,
            kulaniciKodu = sendPar.kulaniciKodu,
            password = sendPar.password,
            qnbUserId = sendPar.qnbUserId,
            rowide = sendPar.rowide
        }},cancellationToken);

        try
        {
            return data.IsSuccess 
                ? new JsonResult(data.Data) 
                : new JsonResult(data.ProblemDetails);
        }
        catch (Exception ex)
        {
            return new JsonResult(ex.Message);

        } 
    } 
}