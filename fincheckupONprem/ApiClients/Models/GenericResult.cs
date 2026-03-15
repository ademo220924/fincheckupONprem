using Microsoft.AspNetCore.Http;
using Refit;
using System.Text.Json.Serialization;

namespace fincheckup.ApiClients.Models;

public class GenericResult<T> where T : class, new()
{

    //public GenericResult() : this(true)
    //{
    //}

    //public GenericResult(bool isSuccess)
    //{
    //    IsSuccess = isSuccess;
    //}

    [JsonPropertyName("isSuccess")] public bool IsSuccess { get; set; }
    [JsonPropertyName("data")] public T? Data { get; set; } = null;
    [JsonPropertyName("problemDetails")] public ProblemDetails ProblemDetails { get; set; } = new();

}
