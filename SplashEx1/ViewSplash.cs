namespace SplashEx
{
    using System.Threading;
    using System.Windows.Forms;

    public partial class ViewSplash : Form
    {
        public ViewSplash()
        {
            InitializeComponent();
            // Тут можно сделать плавный показ формы
        }

        //Делегат для вызова перекрестного потока на закрытие
        private delegate void CloseDelegate();

        //Тип формы, которая будет отображаться как заставка.
        private static ViewSplash splashForm;

        public static void ShowSplashScreen()
        {
            // Убедимся, что он запускается только один раз.
            if (splashForm != null) return;

            splashForm = new ViewSplash();
            Thread thread = new Thread(new ThreadStart(ShowForm))
            {
                IsBackground = true
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            // Тут можно реализовать что-то своё..
            //...
            // await Task.Delay(4500);

            // Время показа окошка
            Thread.Sleep(3000); // 3 сек
        }

        private static void ShowForm()
        {
            if (splashForm != null)
            {
                Application.Run(splashForm);
            }
        }

        public static void CloseForm()
        {
            splashForm?.Invoke(new CloseDelegate(CloseFormInternal));
        }

        private static void CloseFormInternal()
        {
            if (splashForm != null)
            {
                splashForm.Close();
                splashForm = null;
            };
        }

        private void ViewSplash_Load(object sender, System.EventArgs e)
        {
            // Тут можно что-нибудь выполнить при загрузки формы..
        }
    }
}