
namespace SOC.REST.Middlewares
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionHandling(this IApplicationBuilder app)
        => app.UseMiddleware<ErrorHandlingMiddleware>();
    }
}