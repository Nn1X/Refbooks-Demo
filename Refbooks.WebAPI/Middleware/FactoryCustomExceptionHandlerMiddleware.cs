using Refbooks.Application.Common.Exceptions;
using System.Net;
using System.Text.Json;

namespace Refbooks.WebAPI.Middleware
{
    public class FactoryCustomExceptionHandlerMiddleware : IMiddleware
    { 

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;

            switch (exception)
            {
                case NotFoundException:
                    code = HttpStatusCode.NotFound;
                    break;
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            if(string.IsNullOrWhiteSpace(result))
            {
                result = JsonSerializer.Serialize(new { error = exception.Message});
            }

            SetNoCache(context);

            await context.Response.WriteAsync(result);
        }

        private void SetNoCache(HttpContext context)
        {
            context.Response.Headers["Cache-Control"] = "no-cache";
        }
    }
}
