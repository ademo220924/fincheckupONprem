using System.Text.Json;

namespace fincheckup.ApiClients.Models.Responses.Home
{
    public class GetHtmlResponse
    {
        public JsonElement? ResultText { get; set; }
    }
}