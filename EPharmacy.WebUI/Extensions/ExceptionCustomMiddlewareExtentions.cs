using Microsoft.AspNetCore.Builder;
namespace EPharmacy.WebUI.Extensions
{
    public static class ExceptionCustomMiddlewareExtentions
    {
        public static void ConfigureCustomExcepitonMiddlewareForView(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionCustomMiddleware>();
        }
    }
}
