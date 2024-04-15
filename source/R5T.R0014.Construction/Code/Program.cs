using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;


namespace R5T.R0014.Construction
{
    class Program
    {
        static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            builder.Services.AddRazorPages(razorPagesOptions =>
            {
                razorPagesOptions.RootDirectory = "/Routes/Pages";
            });

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}