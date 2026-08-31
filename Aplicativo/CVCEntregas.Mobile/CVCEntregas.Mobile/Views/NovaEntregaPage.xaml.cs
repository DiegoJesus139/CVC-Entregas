namespace CVCEntregas.Mobile.Views;

public partial class NovaEntregaPage : ContentPage
{
    public NovaEntregaPage()
    {
        InitializeComponent();
    }

    private async void OnSalvarPedidoClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtCliente.Text) ||
            string.IsNullOrWhiteSpace(TxtEndereco.Text) ||
            PckMaterial.SelectedIndex == -1)
        {
            await DisplayAlert("Atenção", "Preencha o nome do cliente, endereço e selecione o material.", "OK");
            return;
        }

        string resumoPedido = $"{TxtQuantidade.Text} {PckUnidade.SelectedItem} de {PckMaterial.SelectedItem}";

        await DisplayAlert("Sucesso", $"Pedido cadastrado para {TxtCliente.Text}!\nItem: {resumoPedido}", "OK");

        // Volta para a lista de entregas
        await Navigation.PopAsync();
    }
}
