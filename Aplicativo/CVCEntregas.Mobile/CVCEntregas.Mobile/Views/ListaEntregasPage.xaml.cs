namespace CVCEntregas.Mobile.Views;

public partial class ListaEntregasPage : ContentPage
{
    public ListaEntregasPage(bool isAdmin = false)
    {
        InitializeComponent();

        BtnNovaEntrega.IsVisible = isAdmin;
    }

    private void OnNovaEntregaClicked(object sender, EventArgs e)
    {
        // Redireciona direto para a tela que já criei
        Application.Current!.MainPage = new NovaEntregaPage();
    }
}