using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Extensions.Hosting;

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

            var builder = Host.CreateDefaultBuilder(args);

            builder.Build.AddDbContext<InventoryContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionStrings("InventoryConnection"));
            });

        }
    }
}