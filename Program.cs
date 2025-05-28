using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace bakk_project_task
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            var clientsRepository = new ClientsRepository();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm(clientsRepository));
        }
    }
    public static class WindowFlags//critical for passing control between windows
    {
        public static bool NewClient { get; set; }
    }
}