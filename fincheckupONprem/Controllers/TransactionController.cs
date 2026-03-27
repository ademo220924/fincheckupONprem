using System;
using System.Diagnostics;
using QnbPaymentType = fincheckup.ApiClients.Models.QnbPaymentType;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Transactions;
using fincheckup.ApiClients.Services;
using fincheckup.Extensions;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace fincheckup.Controllers;

public class TransactionController : Controller
{
    private readonly ILogger<TransactionController> _logger;
    private readonly IConfiguration _config;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ITransactionApiClient _transactionApiClient;

    public TransactionController(
        ILogger<TransactionController> logger,
        IConfiguration config,
        IHttpContextAccessor httpContextAccessor,
        ITransactionApiClient transactionApiClient)
    {
        _logger = logger;
        _config = config;
        _httpContextAccessor = httpContextAccessor;
        _transactionApiClient = transactionApiClient;
    }

    public IActionResult PaySmart()
    {
        return View();
    }
    [HttpPost]
    public async Task<ActionResult> PaySmartNomb(IFormCollection form, CancellationToken cancellationToken)
    {
        var request = new PaySmartNombRequest
        {
            PaymentModelRequest = new PaymentModelRequest
            {
                is_recurring_payment = form["is_recurring_payment"],
                recurring_payment_number = form["recurring_payment_number"],
                recurring_payment_cycle = form["recurring_payment_cycle"],
                recurring_payment_interval = form["recurring_payment_interval"],
                CreditCardType = form["CreditCardType"],
                CardholderName = form["CardholderName"],
                CardNumber = form["CardNumber"],
                ExpireMonth = form["ExpireMonth"],
                ExpireYear = form["ExpireYear"],
                Amount = form["Amount"],
                OrderId = form["OrderId"],
                CardCode = form["CardCode"],
                Is3D = form["Is3D"],
                Installment = form["Installment"],
                SelectedPosData = string.IsNullOrEmpty(form["SelectedPosData"])
                    ? new PosData()
                    : JsonConvert.DeserializeObject<PosData>(form["SelectedPosData"])!
            }
        };

        var apiResult = await _transactionApiClient.PaySmartNombAsync(request, cancellationToken);
        return apiResult.IsSuccess ? new JsonResult(apiResult.Data) : new JsonResult(apiResult.ProblemDetails);
    }
    [HttpPost]
    public async Task<ActionResult> PaySmart(IFormCollection form, CancellationToken cancellationToken)
    {
        var request = new PaySmartRequest
        {
            PaymentModelRequest = new PaymentModelRequest
            {
                is_recurring_payment = form["is_recurring_payment"],
                recurring_payment_number = form["recurring_payment_number"],
                recurring_payment_cycle = form["recurring_payment_cycle"],
                recurring_payment_interval = form["recurring_payment_interval"],
                CreditCardType = form["CreditCardType"],
                CardholderName = form["CardholderName"],
                CardNumber = form["card-number"],
                ExpireMonth = form["ExpireMonth"],
                ExpireYear = form["ExpireYear"],
                Amount = string.IsNullOrEmpty(form["Amount"]) ? form["\"Amount"] : form["Amount"],
                OrderId = form["OrderId"],
                CardCode = form["CardCode"],
                Is3D = form["Is3D"],
                Installment = form["Installment"],
                SelectedPosData = string.IsNullOrEmpty(form["SelectedPosData"])
                    ? new PosData()
                    : JsonConvert.DeserializeObject<PosData>(form["SelectedPosData"])!
            }
        };

        var apiResult = await _transactionApiClient.PaySmartAsync(request, cancellationToken);
        return apiResult.IsSuccess ? new JsonResult(apiResult.Data) : new JsonResult(apiResult.ProblemDetails);
    }

    public IActionResult PayWithQNBpay()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Request3D()
    {
        return View();
    }
    [NonAction]
    public PaymentModel GetSmartPaymentInfoNomb(IFormCollection form)
    {
        var paymentInfo = new PaymentModel();

        paymentInfo.CreditCardType = form["CreditCardType"];
        paymentInfo.CreditCardName = form["\"CardholderName"];

        if (!String.IsNullOrEmpty(form["CardNumber"]))
        {
            paymentInfo.CreditCardNumber = form["CardNumber"];
        }
        if (!String.IsNullOrEmpty(form["ExpireMonth"]))
        {
            paymentInfo.CreditCardExpireMonth = int.Parse(form["ExpireMonth"].ToString().Substring(0, 2));
        }
        if (!String.IsNullOrEmpty(form["ExpireMonth"]))
        {
            paymentInfo.CreditCardExpireYear = int.Parse(form["ExpireMonth"].ToString().Substring(2));
        }

        if (!String.IsNullOrEmpty(form["\"Amount"]))
        {
            paymentInfo.Amount = decimal.Parse(form["\"Amount"]);
        }

        if (!String.IsNullOrEmpty(form["Amount"]))
        {
            paymentInfo.Amount = decimal.Parse(form["Amount"]);
        }

        if (!String.IsNullOrEmpty(form["OrderId"]))
        {
            paymentInfo.OrderId = form["OrderId"];
        }
        paymentInfo.CreditCardCvv2 = form["CardCode"];
        paymentInfo.CreditCardCvv2 = paymentInfo.CreditCardCvv2.Substring(0, 3);
        QnbPaymentType paymentType = QnbPaymentType.WhiteLabel2D;
        if (!String.IsNullOrEmpty(form["Is3D"]))
        {
            if (form["Is3D"] == "on") paymentType = QnbPaymentType.WhiteLabel3D;
        }

        paymentInfo.Is3D = paymentType;

        paymentInfo.InstallmentNumber = 1;
        if (!String.IsNullOrEmpty(form["Installment"]))
        {
            paymentInfo.InstallmentNumber = int.Parse(form["Installment"].ToString().Replace("\"", ""));
        }

        return paymentInfo;
    }
    [HttpPost]
    public async Task<ActionResult> PayWithQNBpay(IFormCollection form, CancellationToken cancellationToken)
    {
        var request = new PayWithQNBpayRequest
        {
            PaymentModelRequest = new PaymentModelRequest
            {
                is_recurring_payment = form["is_recurring_payment"],
                recurring_payment_number = form["recurring_payment_number"],
                recurring_payment_cycle = form["recurring_payment_cycle"],
                recurring_payment_interval = form["recurring_payment_interval"],
                Amount = form["Amount"],
                OrderId = form["OrderId"]
            }
        };

        var apiResult = await _transactionApiClient.PayWithQNBpayAsync(request, cancellationToken);
        return apiResult.IsSuccess ? new JsonResult(apiResult.Data) : new JsonResult(apiResult.ProblemDetails);
    }

    public IActionResult Refund()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Refund(IFormCollection form, CancellationToken cancellationToken)
    {
        var request = new RefundRequest
        {
            PaymentModelRequest = new PaymentModelRequest
            {
                Amount = form["Amount"],
                OrderId = form["OrderId"]
            }
        };

        var apiResult = await _transactionApiClient.RefundAsync(request, cancellationToken);
        return apiResult.IsSuccess ? new JsonResult(apiResult.Data) : new JsonResult(apiResult.ProblemDetails);
    }

    public async Task<ActionResult> CheckBinCode(string binCode, decimal amount, bool isRecurring, CancellationToken cancellationToken)
    {
        if (binCode.Length >= 6)
        {
            var request = new CheckBinCodeRequest
            {
                BinCode = binCode,
                Amount = amount,
                IsRecurring = isRecurring
            };

            var apiResult = await _transactionApiClient.CheckBinCodeAsync(request, cancellationToken);
            return apiResult.IsSuccess ? Ok(apiResult.Data) : Ok(apiResult.ProblemDetails);
        }

        return Ok();
    }

    public async Task<IActionResult> SuccessUrl(CancellationToken cancellationToken)
    {
        var request = new SuccessUrlRequest
        {
            _status = HttpContext.Request.Query["_status"],
            order_no = HttpContext.Request.Query["order_no"],
            invoice_id = HttpContext.Request.Query["invoice_id"],
            status_description = HttpContext.Request.Query["status_description"],
            _payment_method = HttpContext.Request.Query["_payment_method"]
        };

        var apiResult = await _transactionApiClient.SuccessUrlAsync(request, cancellationToken);
        if (apiResult.IsSuccess && !string.IsNullOrWhiteSpace(apiResult.Data?.Url))
            return Redirect(apiResult.Data.Url);

        return View();
    }
    public async Task<IActionResult> CancelUrl(CancellationToken cancellationToken)
    {
        var request = new CancelUrlRequest
        {
            error_code = HttpContext.Request.Query["error-code"],
            error = HttpContext.Request.Query["error"],
            invoice_id = HttpContext.Request.Query["invoice_id"],
            _status = HttpContext.Request.Query["_status"],
            order_no = HttpContext.Request.Query["order_no"],
            status_description = HttpContext.Request.Query["status_description"],
            _payment_method = HttpContext.Request.Query["_payment_method"]
        };

        var apiResult = await _transactionApiClient.CancelUrlAsync(request, cancellationToken);
        if (apiResult.IsSuccess && !string.IsNullOrWhiteSpace(apiResult.Data?.Url))
            return Redirect(apiResult.Data.Url);

        return View();
    }
    public async Task<IActionResult> BrandedSuccessUrl(CancellationToken cancellationToken)
    {
        var request = new BrandedSuccessUrlRequest
        {
            invoice_id = HttpContext.Request.Query["invoice_id"]
        };

        var apiResult = await _transactionApiClient.BrandedSuccessUrlAsync(request, cancellationToken);
        if (apiResult.IsSuccess && !string.IsNullOrWhiteSpace(apiResult.Data?.Url))
            return Redirect(apiResult.Data.Url);

        return View();
    }

    public async Task<IActionResult> BrandedCancelUrl(CancellationToken cancellationToken)
    {
        var request = new BrandedCancelUrlRequest
        {
            status = HttpContext.Request.Query["status"],
            success_message = HttpContext.Request.Query["success_message"],
            link = HttpContext.Request.Query["link"]
        };

        var apiResult = await _transactionApiClient.BrandedCancelUrlAsync(request, cancellationToken);
        if (apiResult.IsSuccess && !string.IsNullOrWhiteSpace(apiResult.Data?.Url))
            return Redirect(apiResult.Data.Url);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [NonAction]
    public PaymentModel GetPaymentInfo(IFormCollection form)
    {
        var paymentInfo = new PaymentModel();

        paymentInfo.CreditCardType = form["CreditCardType"];
        paymentInfo.CreditCardName = form["CardholderName"];

        if (!String.IsNullOrEmpty(form["card-number"]))
        {
            paymentInfo.CreditCardNumber = form["card-number"];
        }
        if (!String.IsNullOrEmpty(form["ExpireMonth"]))
        {
            paymentInfo.CreditCardExpireMonth = int.Parse(form["ExpireMonth"]);
        }
        if (!String.IsNullOrEmpty(form["ExpireYear"]))
        {
            paymentInfo.CreditCardExpireYear = int.Parse(form["ExpireYear"]);
        }

        if (!String.IsNullOrEmpty(form["Amount"]))
        {
            paymentInfo.Amount = decimal.Parse(form["Amount"]);
        }

        if (!String.IsNullOrEmpty(form["OrderId"]))
        {
            paymentInfo.OrderId = form["OrderId"];
        }
        paymentInfo.CreditCardCvv2 = form["CardCode"];

        if (!String.IsNullOrEmpty(form["SelectedPosData"]))
        {
            var posData = form["SelectedPosData"];

            paymentInfo.SelectedPosData = JsonConvert.DeserializeObject<PosData>(form["SelectedPosData"]);
        }

        if (!String.IsNullOrEmpty(form["Is3D"]))
        {
            paymentInfo.Is3D = (QnbPaymentType)(Int32.TryParse(form["Is3D"], out int is3D) ? is3D : 0);

        }

        return paymentInfo;
    }

    [NonAction]
    public PaymentModel GetSmartPaymentInfo(IFormCollection form)
    {
        var paymentInfo = new PaymentModel();

        paymentInfo.CreditCardType = form["CreditCardType"];
        paymentInfo.CreditCardName = form["CardholderName"];

        if (!String.IsNullOrEmpty(form["card-number"]))
        {
            paymentInfo.CreditCardNumber = form["card-number"];
        }
        if (!String.IsNullOrEmpty(form["ExpireMonth"]))
        {
            paymentInfo.CreditCardExpireMonth = int.Parse(form["ExpireMonth"]);
        }
        if (!String.IsNullOrEmpty(form["ExpireYear"]))
        {
            paymentInfo.CreditCardExpireYear = int.Parse(form["ExpireYear"]);
        }

        if (!String.IsNullOrEmpty(form["\"Amount"]))
        {
            paymentInfo.Amount = decimal.Parse(form["\"Amount"]);
        }

        if (!String.IsNullOrEmpty(form["Amount"]))
        {
            paymentInfo.Amount = decimal.Parse(form["Amount"]);
        }

        if (!String.IsNullOrEmpty(form["OrderId"]))
        {
            paymentInfo.OrderId = form["OrderId"];
        }
        paymentInfo.CreditCardCvv2 = form["CardCode"];

        QnbPaymentType paymentType = QnbPaymentType.WhiteLabel2D;
        if (!String.IsNullOrEmpty(form["Is3D"]))
        {
            if (form["Is3D"] == "on") paymentType = QnbPaymentType.WhiteLabel3D;
        }

        paymentInfo.Is3D = paymentType;

        paymentInfo.InstallmentNumber = 1;
        if (!String.IsNullOrEmpty(form["Installment"]))
        {
            paymentInfo.InstallmentNumber = int.Parse(form["Installment"].ToString().Replace("\"", ""));
        }

        return paymentInfo;
    }

    [NonAction]
    public (bool, int, string, int) GetRecurringPaymentInfo(IFormCollection form)
    {
        bool is_recurring_payment = false;
        int recurring_payment_number = 0;
        string recurring_payment_cycle = "";
        int recurring_payment_interval = 0;

        if (!String.IsNullOrEmpty(form["is_recurring_payment"]))
        {
            is_recurring_payment = form["is_recurring_payment"] == "on";
            //Boolean.TryParse(form["is_recurring_payment"], out is_recurring_payment);
        }

        if (!String.IsNullOrEmpty(form["recurring_payment_number"]))
        {
            Int32.TryParse(form["recurring_payment_number"], out recurring_payment_number);
        }

        if (!String.IsNullOrEmpty(form["recurring_payment_cycle"]))
        {
            recurring_payment_cycle = form["recurring_payment_cycle"];
        }

        if (!String.IsNullOrEmpty(form["recurring_payment_interval"]))
        {
            Int32.TryParse(form["recurring_payment_interval"], out recurring_payment_interval);
        }

        return (is_recurring_payment, recurring_payment_number, recurring_payment_cycle, recurring_payment_interval);
    }
}
