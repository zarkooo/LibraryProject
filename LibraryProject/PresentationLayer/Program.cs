using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.Interfaces.Repository;
using DataAccessLayer;

using PresentationLayer.CommonForms;

using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Common.Interfaces.Business;
using BusinessLayer;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<LogIn>();
                Application.Run(login);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<ILogInRepository, LogInRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();

            services.AddScoped<IBookBusiness, BookBusiness>();
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<ILogInBusiness, LogInBusiness>();

            services.AddScoped<LogIn>();
        }
    }
}
