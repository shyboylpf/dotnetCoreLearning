using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace StartupDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    Console.WriteLine("ConfigureWebHostDefaults");
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureServices(services =>
                    //{
                    //    Console.WriteLine("Startup.ConfigureServices");
                    //    services.AddControllers();
                    //});
                    //webBuilder.Configure(app =>
                    //{
                    //    Console.WriteLine("Startup.Configure");
                    //    //if (env.IsDevelopment())
                    //    //{
                    //    //    app.UseDeveloperExceptionPage();
                    //    //}

                    //    app.UseHttpsRedirection();

                    //    app.UseRouting();

                    //    app.UseAuthorization();

                    //    app.UseStaticFiles();

                    //    app.UseWebSockets();

                    //    // ×¢²áMVC
                    //    app.UseEndpoints(endpoints =>
                    //    {
                    //        endpoints.MapControllers();
                    //    });
                    //});
                })
                .ConfigureAppConfiguration(builder =>
                {
                    Console.WriteLine("ConfigureAppConfiguration");
                })
                .ConfigureServices(service =>
                {
                    Console.WriteLine("ConfigureServices");
                })
                .ConfigureHostConfiguration(builder =>
                {
                    Console.WriteLine("ConfigureHostConfiguration");
                })
                ;
    }
}