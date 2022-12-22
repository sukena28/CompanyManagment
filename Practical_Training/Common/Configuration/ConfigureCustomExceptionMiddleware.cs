using Practical_Training.Common.Middleware;

namespace Practical_Training.Common.Configuration
{
    public static class ConfigureCustomExceptionMiddleware
    {
        public static void UseCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
