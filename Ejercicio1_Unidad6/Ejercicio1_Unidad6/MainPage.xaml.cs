using Microsoft.Maui.Controls.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Ejercicio1_Unidad6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            Button  boton3 = new Button {
                Text = "boton1",
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
        }
    }
}