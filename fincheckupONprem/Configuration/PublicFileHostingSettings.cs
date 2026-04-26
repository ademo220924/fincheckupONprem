namespace fincheckup.Configuration;

/// <summary>
/// Base URL for files physically served by the API (wwwroot/FileContent/...), e.g. http://localhost:2025
/// </summary>
public class PublicFileHostingSettings
{
    public string BaseUrl { get; set; } = string.Empty;
}
