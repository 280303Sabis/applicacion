namespace applicacion;

public partial class MapPage : ContentView
{
    public MapPage()
    {
        InitializeComponent();

        // URL directa de Google Maps centrada en una ubicaci�n
        string googleMapsUrl = "https://www.google.com/maps/@25.686613,-100.316116,14z"
;

        // Cargar la URL en el WebView
        GoogleMapsWebView.Source = googleMapsUrl;
    }

    private async void OnVerParquimetrosClicked(object sender, EventArgs e)
    {
        // Usar el contexto de la p�gina principal
        await Application.Current.MainPage.DisplayAlert("Parqu�metros", "Mostrando parqu�metros en el mapa.", "OK");
    }

}
