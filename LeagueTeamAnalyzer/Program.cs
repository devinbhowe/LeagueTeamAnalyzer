using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTeamAnalyzer
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

            var app = new DebugAnalyzerUI();
            var controller = new AnalyzerController(app);
            app.SetController(controller);
            Application.Run(app);
        }
    }
}
