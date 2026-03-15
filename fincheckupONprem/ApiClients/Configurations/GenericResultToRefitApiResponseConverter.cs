using fincheckup.ApiClients.Models;
using Refit;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace fincheckup.ApiClients.Configurations;

 


public class GenericResultToRefitApiResponseConverter<T> : JsonConverter<GenericResult<T>> where T : class, new()
{
    public override GenericResult<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Read the JSON document
        using JsonDocument doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        var result = new GenericResult<T>();

        if (root.TryGetProperty("isSuccess", out var isSuccessProp))
        {
            result.IsSuccess = isSuccessProp.GetBoolean();
        }

        if (root.TryGetProperty("data", out var dataProp))
        {
            result.Data = JsonSerializer.Deserialize<T>(dataProp.GetRawText(), options);
        }

        if (root.TryGetProperty("problemDetails", out var problemDetailsProp))
        {
            result.ProblemDetails = JsonSerializer.Deserialize<ProblemDetails>(problemDetailsProp.GetRawText(), options);
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, GenericResult<T> value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteBoolean("isSuccess", value.IsSuccess);

        if (value.Data != null)
        {
            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, value.Data, options);
        }
        else
        {
            writer.WriteNull("data");
        }

        writer.WritePropertyName("problemDetails");
        JsonSerializer.Serialize(writer, value.ProblemDetails, options);

        writer.WriteEndObject();
    }
}