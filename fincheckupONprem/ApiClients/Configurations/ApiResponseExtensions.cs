using fincheckup.ApiClients.Models;
using Refit;

namespace fincheckup.ApiClients.Configurations;

public static class ApiResponseExtensions
{
    public static GenericResult<T> ToGenericResult<T>(this ApiResponse<T> apiResponse) where T : class, new()
    {
        if (apiResponse.IsSuccessStatusCode)
        {
            return new GenericResult<T>
            {
                IsSuccess = true,
                Data = apiResponse.Content
            };
        }

        return new GenericResult<T>
        {
            IsSuccess = false,
            ProblemDetails = new ProblemDetails
            {
                Detail = apiResponse.Error?.Message,
                Status = (int)apiResponse.StatusCode
            }
        };
    }
}