namespace EjT7_AngelNavarroMesas.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private async void Click(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}