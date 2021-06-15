namespace SplashEx
{
    using System;
    using System.Windows.Forms;

    public partial class ViewSplash : Form
    {
        public ViewSplash()
        {
            InitializeComponent();
        }

        public static void ShowSplash()
        {
            var sp = new ViewSplash();
            sp.Show();
            Application.DoEvents();
            var t = new Timer
            {
                Interval = 5000
            };
            t.Tick += new EventHandler((sender, ea) =>
            {
                sp.BeginInvoke(new Action(() =>
                {
                    if (sp != null && Application.OpenForms.Count > 1)
                    {
                        sp.Close();
                        sp.Dispose();
                        sp = null;
                        t.Stop();
                        t.Dispose();
                        t = null;
                    }
                }));
            });
            t.Start();
        }
    }
}