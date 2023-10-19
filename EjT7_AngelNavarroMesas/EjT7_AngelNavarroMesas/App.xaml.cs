using EjT7_AngelNavarroMesas.Views;

namespace EjT7_AngelNavarroMesas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}