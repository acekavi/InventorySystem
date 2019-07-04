using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjectDiSE
{
    static class Program
    {
        static SplashScreen mySplashScreen;
        static Login myLogin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Show Splash Form
            mySplashScreen = new SplashScreen();
            if (mySplashScreen != null)
            {
                Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(mySplashScreen); }));
                splashThread.SetApartmentState(ApartmentState.STA);
                splashThread.Start();
            }
            //Create and Show Main Form
            myLogin = new Login();
            myLogin.LoadCompleted += Login_LoadCompleted;
            Application.Run(myLogin);
            if (!(mySplashScreen == null || mySplashScreen.Disposing || mySplashScreen.IsDisposed))
                mySplashScreen.Invoke(new Action(() => {
                    mySplashScreen.TopMost = true;
                    mySplashScreen.Activate();
                    mySplashScreen.TopMost = false;
                }));
        }
        private static void Login_LoadCompleted(object sender, EventArgs e)
        {
            if (mySplashScreen == null || mySplashScreen.Disposing || mySplashScreen.IsDisposed)
                return;
            mySplashScreen.Invoke(new Action(() => { mySplashScreen.Close(); }));
            mySplashScreen.Dispose();
            mySplashScreen = null;
            myLogin.TopMost = true;
            myLogin.Activate();
            myLogin.TopMost = false;
        }
    }
}
