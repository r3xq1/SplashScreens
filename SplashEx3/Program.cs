namespace SplashEx
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public static class Program
    {
        private static ViewSplash SplashScreen;
        private static Form1 MainForm;

        [STAThread]
        public static void Main()
        {
            using (new Mutex(true, $@"Local\{MutEx.GUID}", out bool flag))
            {
                if (flag)
                {
                    SplashScreen = new ViewSplash();
                    var splashThread = new Thread(new ThreadStart(() => Application.Run(SplashScreen)));
                    splashThread.SetApartmentState(ApartmentState.STA);
                    splashThread.Start();
                    Thread.Sleep(5000);
                    // await Task.Delay(4500);
                    MainForm = new Form1();
                    MainForm.Load += MainForm_LoadCompleted;
                    Application.Run(MainForm);
                }
            }
        }

        private static void MainForm_LoadCompleted(object sender, EventArgs e)
        {
            if (SplashScreen != null && !SplashScreen.Disposing && !SplashScreen.IsDisposed)
            {
                SplashScreen.Invoke(new Action(() => SplashScreen.Close()));
            }
            MainForm.TopMost = true;
            MainForm.Activate();
            MainForm.TopMost = false;
        }
    }
}