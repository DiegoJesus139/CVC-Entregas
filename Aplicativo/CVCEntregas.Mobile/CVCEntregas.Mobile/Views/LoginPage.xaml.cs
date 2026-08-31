namespace CVCEntregas.Mobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text;
        string senha = TxtSenha.Text;

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Atenção", "Preencha usuário e senha para entrar.", "OK");
            return;
        }

        // Navega para a tela de lista de entregas do motorista
        Application.Current.MainPage = new NavigationPage(new ListaEntregasPage());
    }
}