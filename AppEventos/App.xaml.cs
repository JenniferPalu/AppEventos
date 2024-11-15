namespace AppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Inicial());
        }
        protected override Window CreateWindow(IActivationState? activationsState)
        {
            var window = base.CreateWindow(activationsState);
            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}
