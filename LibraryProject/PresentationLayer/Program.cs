using Common.Interfaces.Repository;
using DataAccessLayer;

using PresentationLayer.CommonForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new LogIn());
        }

     /*   private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<ILogInRepository, LogInRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }*/
    }
}
