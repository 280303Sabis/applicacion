namespace applicacion
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        // Maneja el clic del botón "Enviar"
        private async void OnEnviarClicked(object sender, EventArgs e)
        {
            // Muestra un mensaje de registro exitoso
            await DisplayAlert("Registro Exitoso", "¡Te has registrado exitosamente!", "OK");
        }
    }
}