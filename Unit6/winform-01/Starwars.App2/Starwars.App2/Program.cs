using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Starwars.Core.Business;
using Starwars.Core.Business.Interfaces;

namespace Starwars.App2
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()

                .ConfigureServices((context, services) => {


                    using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                    ILogger logger = factory.CreateLogger("Program");

                    services.AddTransient<ILogger>(x=> logger);
                    services.AddTransient<IJedisBusiness, JedisBusiness>();
                    //services.AddTransient<IJedisBusiness, JedisNewOrderBusiness>();
                    services.AddTransient<Form1>();
                    services.AddTransient<Form2>();
                });
        }

    }
}