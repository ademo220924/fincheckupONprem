using fincheckup.ApiClients.Models.Common;

namespace fincheckup.ApiClients.Models;

public class RefundResponse : ClientResponseModel
{
    public string order_no { get; set; }
    public string invoice_id { get; set; }
    public string ref_no { get; set; }
}