using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LivePerformance_NJ_2017.Data;
using LivePerformance_NJ_2017.Logic;

namespace LivePerformance_NJ_2017
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

            lblCoalitie form = new lblCoalitie(context);
            Application.Run(form);
        }
    }
}
