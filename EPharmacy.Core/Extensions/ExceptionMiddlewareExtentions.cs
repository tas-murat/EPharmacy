using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPharmacy.Core.Extensions
{
    public static class ExceptionMiddlewareExtentions
    {
        public static void ConfigureCustomExcepitonMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
