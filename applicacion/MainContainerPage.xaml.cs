namespace applicacion;

public partial class MainContainerPage : ContentPage
{
    public MainContainerPage()
    {
        InitializeComponent();

        // Cargar p�gina inicial
        PageContainer.Content = new HomePage().Content;
    }

    // Bot�n Recarga
    private void OnRecargaClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new RecargaPage().Content;
    }

    // Bot�n Historial
    private void OnHistorialClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new HistoryPage().Content;
    }

    // Bot�n Inicio
    private void OnInicioClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new HomePage().Content;
    }

    // Bot�n Mapa
    private void OnMapaClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new MapPage().Content;
    }

    // Bot�n Perfil
    private void OnPerfilClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new ProfilePage().Content;
    }
}
