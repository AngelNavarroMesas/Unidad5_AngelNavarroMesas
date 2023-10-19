namespace EjT7_AngelNavarroMesas.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagTabbed());
        }

        private async void ClickPag4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina4());
        }

        private async void ClickPag5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina5());
        }
    }
}