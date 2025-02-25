using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace aplicacionInventario4
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddDbContext<InventoryContext>(options =>
            {
                options.UseSqlServer("InventoryConnection");
            });

            var app = builder.Build();

            using (var serviceScope = app.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var context = services.GetRequiredService<InventoryContext>();
                context.Database.EnsureCreated();
                context.Database.Migrate();
            }

        }
    }
}