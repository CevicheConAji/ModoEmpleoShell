namespace ModoEmpleoShell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
            Routing.RegisterRoute(nameof(Pages.Page3), typeof(Pages.Page3));
        }
    }
}
