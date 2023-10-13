using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Ejercicio1_Unidad6
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        Boolean btnYaCreado = false;

        private void Click(object sender, EventArgs e){

            Button boton3 = new Button();

            if (btnYaCreado==false) {
                boton3 = new Button {
                    Text = "boton3",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Background = Color.FromArgb("0008ff"),
                    HeightRequest = 70,
                    WidthRequest = 200,
                    FontFamily = "Verdana",
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 16,
                    BorderColor = Color.FromArgb("#f0fc03"),
                    Margin = 30
                };
                btnYaCreado = true;

                vSLButtons.Children.Add(boton3);
            }
            boton3.Clicked += new EventHandler(ClickBtn3); 
        }

        private void ClickBtn3(object sender, EventArgs e)
        {
            vSLButtons.Children.Remove(boton1);
            boton2.Text = "Crear controles en tiempo de ejecucion mola";
        }
    }
}