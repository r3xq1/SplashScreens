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

        private readonly Timer timer1 = new Timer();

        public void ViewSplash_Load(object sender, EventArgs e)
        {
            // Время показа Splash Screen (окошка)
            timer1.Interval = 4000; 
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(Timer1_Tick); // обработчик события таймера
            timer1.Start();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Останавливаем таймер
            new Form1().Show(); // Показываем форму
            this.Hide(); // Скрываем Splash Screen
        }
    }
}