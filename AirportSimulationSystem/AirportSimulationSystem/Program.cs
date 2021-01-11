using System;
using System.Configuration;
using System.Windows.Forms;
using AirportSimulationSystem.Database;
using AirportSimulationSystem.Services;
using AirportSimulationSystem.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AirportSimulationSystem
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connString = ConfigurationManager.ConnectionStrings["AirportDatabase"].ConnectionString;

            var builder = new HostBuilder()
              .ConfigureServices((_, services) =>
              {
                  services.AddDbContext<AirportContext>(options => options.UseSqlServer(connString));
                  services.AddScoped<MainForm>();
                  services.AddScoped<IAirplaneService, AirplaneService>();
                  services.AddScoped<ICityService, CityService>();
                  services.AddScoped<IFlightService, FlightService>();
              });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    var form1 = services.GetRequiredService<MainForm>();
                    Application.Run(form1);

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured");
                }
            }
        }
    }
}