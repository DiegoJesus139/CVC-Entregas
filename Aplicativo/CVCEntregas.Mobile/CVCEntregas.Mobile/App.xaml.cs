namespace CVCEntregas.Mobile;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Altere esta linha para abrir a LoginPage primeiro:
        MainPage = new Views.LoginPage();
    }
}
