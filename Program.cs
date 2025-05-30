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
            if (ConfigurationManager.AppSettings["UseDX"] == "true")
            {
                // Use DevExpress UI
                Application.Run(new DXMainMenuForm(clientsRepository));
                //DevExpress.Skins.SkinManager.EnableFormSkins();
                //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
                //skins
            }
            else
            {
                // Use standard Windows Forms UI
                Application.Run(new MainMenuForm(clientsRepository));
            }
            
        }
    }
}