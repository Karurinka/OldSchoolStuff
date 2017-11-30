using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BoodschApp.Data;
using BoodschApp.Logic;

namespace BoodschApp
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

            IContext context;
            string config = ConfigurationManager.AppSettings["ContextType"];

            if (config == "SQL")
            {
                context = new MSSQLContext();
            }
            else
            {
                throw new Exception("Fout bij het inlezen van de app.config");
            }

            Form1 form = new Form1(context);
            Application.Run(form);
        }
    }
}
