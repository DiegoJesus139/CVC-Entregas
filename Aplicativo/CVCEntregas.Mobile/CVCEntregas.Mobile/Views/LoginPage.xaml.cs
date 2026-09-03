using CVCEntregas.Mobile.Views;

namespace CVCEntregas.Mobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnEntrarClicked(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text?.Trim().ToLower() ?? "";
        string senha = TxtSenha.Text?.Trim() ?? "";

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
        {
            await DisplayAlert("Atenção", "Por favor, informe o usuário e a senha.", "OK");
            return;
        }

        if (usuario == "adm" && senha == "123")
        {
            await DisplayAlert("Sucesso", "Bem-vindo, Administrador!", "OK");
            // Abre a lista com acesso de ADM (exibe o botão de criar entrega)
            Application.Current!.MainPage = new ListaEntregasPage(isAdmin: true);
        }
        else if (usuario == "motorista" && senha == "123")
        {
            await DisplayAlert("Sucesso", "Bem-vindo, Motorista!", "OK");
            // Abre a lista apenas para consulta
            Application.Current!.MainPage = new ListaEntregasPage(isAdmin: false);
        }
        else
        {
            await DisplayAlert("Erro", "Usuário ou senha inválidos!", "OK");
        }
    }
}