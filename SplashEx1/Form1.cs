namespace SplashEx
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Можно сделать плавное появление второй формы (так же в Form1_Load)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;
            Focus(); 
            Show();
        }
    }
}