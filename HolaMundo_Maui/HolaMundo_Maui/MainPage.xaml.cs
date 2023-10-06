using biblioteca;

namespace HolaMundo_Maui
{
    public partial class MainPage : ContentPage
    {
        private ClsPersona persona = new ClsPersona();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

            persona.Nombre = nombre.Text;
            persona.Apellidos = await DisplayPromptAsync("Pregunta", "Cual es tu apellido");

            if (!string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(persona.Apellidos))
            {
                await DisplayAlert("Hola",persona.NombreCompleto, "OK");
            }



        }
    }
}