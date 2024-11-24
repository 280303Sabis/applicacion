namespace applicacion;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Establece MainPage como la página inicial
        MainPage = new NavigationPage(new MainPage());
    }
}


