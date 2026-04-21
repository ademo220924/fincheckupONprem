using System.Collections.Generic;
using System.Text.Json.Serialization;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Responses.Finance.ReportZone;

/// <summary>
/// ReportCheckZoneold, ReportCheckZoneMain ve ComReport içinde rapor datasource'larına bağlanan ortak durumun API taşıması.
/// Refit <see cref="System.Text.Json.JsonSerializerDefaults.Web"/> camelCase kullanır; eski helper/InitialModel ile aynı JSON anahtarları için
/// <see cref="JsonPropertyNameAttribute"/> ile hizalanmıştır (ör. <c>nchecklast</c>, <c>ncheckchartb</c>).
/// Renkler System.Drawing.Color yerine ARGB int olarak taşınır.
/// </summary>
public class FinancialReportZonePayloadResponse
{
    [JsonPropertyName("ncheck")]
    public List<ReportMainItem> Ncheck { get; set; }
    [JsonPropertyName("nchecklast")]
    public List<ReportMainItem> NcheckLast { get; set; }
    [JsonPropertyName("nchecka")]
    public List<ReportMainItem> NcheckA { get; set; }
    [JsonPropertyName("ncheck1")]
    public List<ReportMainItem> Ncheck1 { get; set; }
    [JsonPropertyName("ncheck1a")]
    public List<ReportMainItem> Ncheck1a { get; set; }
    [JsonPropertyName("ncheckb")]
    public List<ReportMainItem> NcheckB { get; set; }
    [JsonPropertyName("ncheckc")]
    public List<ReportMainItem> NcheckC { get; set; }
    [JsonPropertyName("ncheckd")]
    public List<ReportMainItem> NcheckD { get; set; }
    [JsonPropertyName("nchecke")]
    public List<ReportMainItem> NcheckE { get; set; }
    [JsonPropertyName("ncheckf")]
    public List<ReportMainItem> NcheckF { get; set; }
    [JsonPropertyName("ncheckg")]
    public List<ReportMainItem> NcheckG { get; set; }
    /// <summary>Helper’daki ncheck1_ listesi.</summary>
    [JsonPropertyName("ncheck1_")]
    public List<ReportMainItem> Ncheck1Underscore { get; set; }
    [JsonPropertyName("ncheck2")]
    public List<ReportMainItem> Ncheck2 { get; set; }
    [JsonPropertyName("ncheck3")]
    public List<ReportMainItem> Ncheck3 { get; set; }
    [JsonPropertyName("ncheck4")]
    public List<ReportMainItem> Ncheck4 { get; set; }
    [JsonPropertyName("ncheck5")]
    public List<ReportMainItem> Ncheck5 { get; set; }
    [JsonPropertyName("ncheck6")]
    public List<ReportMainItem> Ncheck6 { get; set; }
    [JsonPropertyName("ncheck7")]
    public List<ReportMainItem> Ncheck7 { get; set; }
    [JsonPropertyName("ncheck8")]
    public List<ReportMainItem> Ncheck8 { get; set; }
    [JsonPropertyName("ncheck9")]
    public List<ReportMainItem> Ncheck9 { get; set; }
    [JsonPropertyName("ncheck10")]
    public List<ReportMainItem> Ncheck10 { get; set; }
    [JsonPropertyName("ncheck11")]
    public List<ReportMainItem> Ncheck11 { get; set; }
    [JsonPropertyName("ncheck12")]
    public List<ReportMainItem> Ncheck12 { get; set; }

    [JsonPropertyName("ncheckKapak")]
    public ReportKapak NcheckKapak { get; set; }

    [JsonPropertyName("shapeArgb1")]
    public int? ShapeArgb1 { get; set; }
    [JsonPropertyName("shapeArgb2")]
    public int? ShapeArgb2 { get; set; }
    [JsonPropertyName("shapeArgb3")]
    public int? ShapeArgb3 { get; set; }
    [JsonPropertyName("shapeArgb4")]
    public int? ShapeArgb4 { get; set; }
    [JsonPropertyName("shapeArgb5")]
    public int? ShapeArgb5 { get; set; }
    [JsonPropertyName("shapeArgb6")]
    public int? ShapeArgb6 { get; set; }
    [JsonPropertyName("shapeArgb7")]
    public int? ShapeArgb7 { get; set; }
    [JsonPropertyName("shapeArgb8")]
    public int? ShapeArgb8 { get; set; }
    [JsonPropertyName("shapeArgb9")]
    public int? ShapeArgb9 { get; set; }

    [JsonPropertyName("ncheckchart")]
    public List<ReportMainChart> NcheckChart { get; set; }
    [JsonPropertyName("ncheckchartb")]
    public List<ReportMainChart> NcheckChartB { get; set; }
    [JsonPropertyName("ncheckchart1")]
    public List<ReportMainChart> NcheckChart1 { get; set; }
    [JsonPropertyName("ncheckchart2")]
    public List<ReportMainChart> NcheckChart2 { get; set; }
    [JsonPropertyName("ncheckchart3")]
    public List<ReportMainChart> NcheckChart3 { get; set; }
    [JsonPropertyName("ncheckchart4")]
    public List<ReportMainChart> NcheckChart4 { get; set; }
    [JsonPropertyName("ncheckchart5")]
    public List<ReportMainChart> NcheckChart5 { get; set; }
    [JsonPropertyName("ncheckchart6")]
    public List<ReportMainChart> NcheckChart6 { get; set; }
    [JsonPropertyName("ncheckchart7")]
    public List<ReportMainChart> NcheckChart7 { get; set; }
    [JsonPropertyName("ncheckchart8")]
    public List<ReportMainChart> NcheckChart8 { get; set; }
    [JsonPropertyName("ncheckchart9")]
    public List<ReportMainChart> NcheckChart9 { get; set; }
    [JsonPropertyName("ncheckchart10")]
    public List<ReportMainChart> NcheckChart10 { get; set; }
    [JsonPropertyName("ncheckchart11")]
    public List<ReportMainChart> NcheckChart11 { get; set; }
    [JsonPropertyName("ncheckchart12")]
    public List<ReportMainChart> NcheckChart12 { get; set; }

    [JsonPropertyName("rdColor")]
    public RiskDataColor RdColor { get; set; }
    [JsonPropertyName("riskdata")]
    public RiskData RiskData { get; set; }
    [JsonPropertyName("riskdatachk")]
    public RiskData RiskDataChk { get; set; }

    [JsonPropertyName("compnacecode")]
    public int CompNaceCode { get; set; }
    [JsonPropertyName("repchakec")]
    public string Repchakec { get; set; }
    [JsonPropertyName("header")]
    public string Header { get; set; }
    [JsonPropertyName("nccode")]
    public string Nccode { get; set; }
    [JsonPropertyName("yearCount")]
    public int? YearCount { get; set; }
    [JsonPropertyName("isfailed")]
    public bool? Isfailed { get; set; }

    [JsonPropertyName("fields")]
    public List<string> Fields { get; set; }
    [JsonPropertyName("fieldsHeader")]
    public List<string> FieldsHeader { get; set; }
}
