using System.IO;
using System.Text;
using System.Text.Json;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.Helper
{
    /// <summary>
    /// API camelCase satırları PivotGrid (PropertyNamingPolicy=null / PascalCase alan adları) ile uyumlu JSON'a çevirir.
    /// </summary>
    public static class DevExtremeMarkupMarjinPayloadNormalizer
    {
        private static readonly JsonSerializerOptions DeserializeCamelRowOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private static readonly JsonSerializerOptions SerializePascalRowOptions = new()
        {
            PropertyNamingPolicy = null
        };

        public static string? TryNormalizeDashBilancoViewMultiPayload(string json) =>
            TryNormalizeDataPayload<DashBilancoViewMulti>(json);

        public static string? TryNormalizeDashBilancoViewMznShortPayload(string json) =>
            TryNormalizeDataPayload<DashBilancoViewMznShort>(json);

        public static string? TryNormalizeCashflowViewPayload(string json) =>
            TryNormalizeDataPayload<CashflowView>(json);

        /// <summary>
        /// UpPage aktarma yıllık satır istatistikleri (mainYear, tRowCount, …) için PascalCase çıktı.
        /// </summary>
        public static string? TryNormalizeYearlyErrorResultPayload(string json) =>
            TryNormalizeDataPayload<YearlyErrorResult>(json);

        private static string? TryNormalizeDataPayload<T>(string json) where T : class
        {
            try
            {
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;
                if (root.ValueKind != JsonValueKind.Object)
                {
                    return null;
                }

                JsonElement dataElement = default;
                var dataPropertyName = "data";
                var foundData = false;
                foreach (var p in root.EnumerateObject())
                {
                    if (string.Equals(p.Name, "data", StringComparison.OrdinalIgnoreCase) && p.Value.ValueKind == JsonValueKind.Array)
                    {
                        dataElement = p.Value;
                        dataPropertyName = p.Name;
                        foundData = true;
                        break;
                    }
                }

                if (!foundData)
                {
                    return null;
                }

                var rows = dataElement.Deserialize<List<T>>(DeserializeCamelRowOptions);
                if (rows is null)
                {
                    return null;
                }

                using var ms = new MemoryStream();
                using (var writer = new Utf8JsonWriter(ms))
                {
                    writer.WriteStartObject();
                    foreach (var prop in root.EnumerateObject())
                    {
                        if (string.Equals(prop.Name, "data", StringComparison.OrdinalIgnoreCase))
                        {
                            writer.WritePropertyName(dataPropertyName);
                            writer.WriteStartArray();
                            foreach (var row in rows)
                            {
                                JsonSerializer.Serialize(writer, row, SerializePascalRowOptions);
                            }

                            writer.WriteEndArray();
                        }
                        else
                        {
                            prop.WriteTo(writer);
                        }
                    }

                    writer.WriteEndObject();
                }

                return Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (JsonException)
            {
                return null;
            }
        }
    }
}
