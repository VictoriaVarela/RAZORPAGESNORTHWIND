using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RAZORPAGESNORTHWIND.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAZORPAGESNORTHWIND
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var Host= CreateHostBuilder(args).Build();

            using var Scope = Host.Services.CreateScope();
            var Services = Scope.ServiceProvider;
            try
            {
                SeedData.Initialize(Services);
            }
            catch (Exception ex)
            {
                var Logger =
                    Services.GetRequiredService<ILogger<Program>>();
                Logger.LogError(ex, "Error al inicializar la tabla Product");
            }

            Host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
