namespace SplashEx
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public static class Program
    {   
        [STAThread]
        public static void Main()
        {
            using (new Mutex(true, $@"Local\{MutEx.GUID}", out bool flag))
            {
                if (flag)
                {
                    ViewSplash.ShowSplashScreen();
                    ViewSplash.CloseForm();
                    Application.Run(new Form1());
                }
            }
        }
    }
}