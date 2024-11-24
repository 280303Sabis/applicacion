namespace applicacion
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnIngresarConfirmadoClicked(object sender, EventArgs e)
        {
            // Muestra el mensaje de bienvenida y redirige a HomePage
            bool response = await DisplayAlert("Bienvenido", "¡Has iniciado sesión exitosamente!", "OK", "Cancelar");
            if (response) // Si presiona OK
            {
                await Navigation.PushAsync(new MainContainerPage());
            }
        }
    }
}

