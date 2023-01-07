using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SOC.Common.Exceptions;

namespace SOC.REST.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ErrorHandlingMiddleware> logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await this.next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var problemDetails = GetDefaultProblemDetails(context.TraceIdentifier);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            logger.LogError(exception.ToString());

            switch (exception)
            {
                case ObjectNotFoundException:
                    problemDetails.Status = context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    problemDetails.Type = "https://www.rfc-editor.org/rfc/rfc7231#section-6.5.4";
                    problemDetails.Title = "Object not found";
                    problemDetails.Detail = exception.Message;
                    break;
                case DbUpdateException:
                    problemDetails.Detail = "Failed to save object to database.";
                    break;
            }

            await context.Response.WriteAsJsonAsync(problemDetails);
        }

        private ProblemDetails GetDefaultProblemDetails(String traceId)
        {
            var problemDetails = new ProblemDetails();
            problemDetails.Type = "https://www.rfc-editor.org/rfc/rfc7231#section-6.6.1";
            problemDetails.Title = "Internal server error";
            problemDetails.Detail = "Internal server error occurred.";
            problemDetails.Status = (int)HttpStatusCode.InternalServerError;
            problemDetails.Extensions.Add("traceId", traceId);
            return problemDetails;
        }

    }
}