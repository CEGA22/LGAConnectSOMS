using LGAConnectSOMS.Properties;
using LGAConnectSOMS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGAConnectSOMS
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
            //Settings.Default.ID = 0;
            if(Settings.Default.ID != 0)
            {
                if(Settings.Default.IsAdmin == 1)
                {
                    Application.Run(new HomeViewAdmin());
                }

                else if(Settings.Default.IsAdmin == 0)
                {
                    Application.Run(new HomeViewTeacher());
                }

                
            }

            else if(Settings.Default.ID == 0)
            {
                Application.Run(new LoginPageView());
            }
                                               
        }

       
    }
}
