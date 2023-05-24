namespace MISA.WebFresher032023.Demo.Middleware
{
    public class EmployeeMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello Dear Readers ...");
        }
    }

    //public static class ClassWithNoImplementationMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseClassWithNoImplementationMiddleware(this IApplicationBuilder)
    //    {
    //    }
    //}
}
