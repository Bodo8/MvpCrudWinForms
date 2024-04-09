using CrudWinFormsMvp.AppConnection;
using CrudWinFormsMvp.Models;
using CrudWinFormsMvp.Presenters;
using CrudWinFormsMvp.Views;
using Microsoft.Extensions.Configuration;

namespace CrudWinFormsMvp
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            AppConnectionString.SqlConnectionString = Configuration.GetConnectionString("SqlDb");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PetView view = new PetView();
            IPetRepository repository = new PetRepository();
            PetPresenter petPresenter = new (view, repository);

            Application.Run(view);
        }
    }
}