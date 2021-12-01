using Elastic.Apm.SerilogEnricher;
using Elastic.CommonSchema.Serilog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using System;
using System.Net.Sockets;
using Thynk.Covid19Pcr.Application.Models.Settings;

namespace Thynk.Covid19Pcr.API
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            CovidSettings settings = new ();
            configuration.GetSection(nameof(CovidSettings)).Bind(settings);

            if (settings.IsWriteToKibana)
            {
                Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Thynk.Software", "Covid-19 PCR Service")
                .Enrich.WithElasticApmCorrelationInfo()
                .WriteTo.Udp(settings.KibanaUrl, settings.KibanaPort, AddressFamily.InterNetwork, new EcsTextFormatter())
                .CreateLogger();
            }
            else
            {
                Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .Enrich.WithProperty("Thynk.Software", "Covid-19 PCR Service")
                .WriteTo.Seq(settings.SeqUrl)
                .CreateLogger();
            }

            try
            {
                Log.Information("Starting ENaira Service...");
                CreateHostBuilder(args)
                    .UseSerilog()
                    .Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Thynk.Covid19 Application start-up failed");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog();
    }
}
