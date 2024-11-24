namespace applicacion;

public partial class MainContainerPage : ContentPage
{
    public MainContainerPage()
    {
        InitializeComponent();

        // Cargar página inicial
        PageContainer.Content = new HomePage().Content;
    }

    // Botón Recarga
    private void OnRecargaClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new RecargaPage().Content;
    }

    // Botón Historial
    private void OnHistorialClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new HistoryPage().Content;
    }

    // Botón Inicio
    private void OnInicioClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new HomePage().Content;
    }

    // Botón Mapa
    private void OnMapaClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new MapPage().Content;
    }

    // Botón Perfil
    private void OnPerfilClicked(object sender, EventArgs e)
    {
        PageContainer.Content = new ProfilePage().Content;
    }
}
