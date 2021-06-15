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
                    ViewSplash.ShowSplash();
                    // await Task.Delay(4500);
                    Thread.Sleep(5000); // время выставляем как у таймера в ViewSplash
                    Application.Run(new Form1());
                }
            }
        }
    }
}