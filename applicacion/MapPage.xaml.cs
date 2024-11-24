namespace applicacion;

public partial class MapPage : ContentView
{
    public MapPage()
    {
        InitializeComponent();

        // URL directa de Google Maps centrada en una ubicación
        string googleMapsUrl = "https://www.google.com/maps/@25.686613,-100.316116,14z"
;

        // Cargar la URL en el WebView
        GoogleMapsWebView.Source = googleMapsUrl;
    }

    private async void OnVerParquimetrosClicked(object sender, EventArgs e)
    {
        // Usar el contexto de la página principal
        await Application.Current.MainPage.DisplayAlert("Parquímetros", "Mostrando parquímetros en el mapa.", "OK");
    }

}
