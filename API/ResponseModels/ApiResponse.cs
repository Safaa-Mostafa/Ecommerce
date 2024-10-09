namespace API.ResponseModels
{
    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public int StatusCode { get; set; }

        // Constructor for custom messages and data
        public ApiResponse(bool status, string message, T data, int statusCode = 200)
        {
            Status = status;
            Message = message;
            Data = data;
            StatusCode = statusCode;
        }

        // Constructor for error handling with multiple errors
        public ApiResponse(bool status, List<string> errors, string message = "An error occurred", int statusCode = 500)
        {
            Status = status;
            Errors = errors ?? new List<string>(); // Ensure it's not null
            Message = message;
            Data = default(T); // No data for error responses
            StatusCode = statusCode;
        }

        // Factory method for success responses
        public static ApiResponse<T> SuccessResponse(T data, string message = "Request successful", int statusCode = 200)
        {
            return new ApiResponse<T>(true, message, data, statusCode);
        }

        // Factory method for error responses
        public static ApiResponse<T> ErrorResponse(List<string> errors, string message = "An error occurred", int statusCode = 400)
        {
            return new ApiResponse<T>(false, errors, message, statusCode);
        }

        // Default message based on status code
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad request, please check your input.",
                401 => "Unauthorized access.",
                403 => "You do not have permission to access this resource.",
                404 => "Resource not found.",
                500 => "An internal server error occurred.",
                _ => "An unexpected error occurred."
            };
        }
    }
}
