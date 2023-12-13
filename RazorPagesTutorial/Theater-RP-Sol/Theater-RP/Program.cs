/**
 * Author: Aidan Linerud
 * Date: 11/8/2023
 * Assignment: Razor Pages Tutorial
 */

using Microsoft.AspNetCore.Mvc;

namespace Theater_RP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // Add to template
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();
            builder.Services.AddMvc().AddRazorPagesOptions(o => // Add razor pages conventions
            {
                o.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
                o.Conventions.AddPageRoute("/Reservation", "");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession(); // Enables use of sesion data
            app.UseRouting();

            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
            });

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}