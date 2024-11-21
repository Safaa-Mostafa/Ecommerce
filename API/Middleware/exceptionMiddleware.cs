using API.ResponseModels;
using System.Net;
using System.Text.Json;

namespace API.Middleware
{
    public class exceptionMiddleware
    {
        private readonly RequestDelegate _next;
        // to log exception
        private readonly ILogger<exceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;


        public exceptionMiddleware(RequestDelegate requestDelegate, ILogger<exceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = requestDelegate;
            _logger = logger;
            _env = env;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // log error to logger
                _logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var response = _env.IsDevelopment()
                    ? ApiResponse<string>.ErrorResponse(new List<string> { ex.StackTrace.ToString() ?? "No stack trace available" }, ex.Message, (int)HttpStatusCode.InternalServerError)
                    : ApiResponse<string>.ErrorResponse(new List<string> { "An unexpected error occurred. Please try again later." }, "Internal Server Error", (int)HttpStatusCode.InternalServerError);
                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }

        }
    }
}
