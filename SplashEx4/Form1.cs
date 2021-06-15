namespace SplashEx
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Focus(); // Устанавливаем фокус на форму
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var ss = new ViewSplash();
            ss.Close(); // Закрываем окно Splash Screen
            // Закрываем програму полностью
            Application.Exit();
        }
    }
}