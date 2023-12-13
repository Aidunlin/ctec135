/*
Author: Aidan Linerud and Keziah Njoroge
Date: 11/08/2023
Assignment: Final Project
*/

using Microsoft.AspNetCore.Mvc;

namespace AutoRental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(Path.GetFullPath($"App_Data/Theater.mdf"));

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // Added to template
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(); // enable use of session state
            builder.Services.AddMvc().AddRazorPagesOptions(o =>
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

            app.UseSession(); // enable use of session state

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}