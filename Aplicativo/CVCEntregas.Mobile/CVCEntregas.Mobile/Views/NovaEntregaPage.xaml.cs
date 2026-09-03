namespace CVCEntregas.Mobile.Views;

public partial class NovaEntregaPage : ContentPage
{
    public NovaEntregaPage()
    {
        InitializeComponent();
    }

    private async void OnSalvarPedidoClicked(object sender, EventArgs e)
    {
        // Exibe mensagem de sucesso
        await DisplayAlert("Sucesso", "Entrega cadastrada com sucesso!", "OK");

        // Retorna para a lista de entregas logado como Administrador
        Application.Current!.MainPage = new ListaEntregasPage(isAdmin: true);
    }
}