using Microsoft.Maui.Controls;

namespace applicacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // navegación al presionar "Ingresar"
        private async void OnIngresarClicked(object sender, EventArgs e)
        {
            // Navega a la nueva página de ingreso
            await Navigation.PushAsync(new LoginPage());
        }

        // navegación al presionar "Registrar"
        private async void OnRegistrarClicked(object sender, EventArgs e)
        {
            // Navega a la nueva página de registro
            await Navigation.PushAsync(new RegisterPage());
        }

    }
}
