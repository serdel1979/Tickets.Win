using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TicketApp.Services.Data;
using TicketApp.Services.Login;

namespace TicketApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = CreateHostBuilder();
            var host = builder.Build();
            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<Login>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {

                    services.Configure<ApiSettings>(context.Configuration.GetSection("ApiSettings"));
                    services.Configure<AppSettings>(context.Configuration.GetSection("AppSettings"));

                    services.AddTransient<ILoginService, LoginService>();
                    services.AddTransient<Login>();
                });
        }



    }
}